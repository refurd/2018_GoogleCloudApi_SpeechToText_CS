/*Linkek
 * https://cloud.google.com/speech-to-text/docs/basics A google speech api használatához szükséges kritáriumok
 * Szinkron kérésre van szükség, ha végzett egy hangfile felvételével küldje el a pufferben lévő adatot
 * https://www.youtube.com/watch?v=xug793JfqSE&t=64s
 * Így kell a microsoft beépített beszédfelismerőjét beállítani
 * https://stackoverflow.com/questions/37148997/trying-to-understand-buffers-with-regard-to-naudio-in-c-sharp egy mintaprojekt az audio adatok kiolvasására
 * https://archive.codeplex.com/?p=voicerecorder mintaprojekt NAudio használatához
 * 
 * 
 * 
 */
/*Megjegyzések
 * nem törli a függvény a dinamikus táblát ha nem talál semmit
* A mellékelt video szerint a microsoft gyári nyelvi csomagját használva
* folyamatosan futtatja néhány adott szó figyelését.
* A beállításhoz a windowson le kell tölteni az angol nyelvfelismerő csomagját
* amihez a regeditben rendszergazdaként futtatva át kell írni egy változót 0-ra.
* hibakód 0x800f0954
* ezután nem elég a beviteli nyelvet, hanem mindent angolra kell állítani ahhoz, hogy működjön,
* újraindítás/ki-,bejelentkezés után működik
*/
/*Leírás
 * A main-ben futtat egy folyamatosan adott szót figyelő programot
 * Ha észlelte a szót, akkor leírja a textboxba
 * 
 * A bevitt szöveget először felosztja részegységekre és legfeljebb 10 parancsmondatot generál a szövegből úgy, hogy felosztja aszerint,
 *      hogy hol talált állítmányt. Ha állítmányt talál, akkor kitörli a szövegből, és a maradékkal dolgozik tovább (hogy hogyan? fogalmam sincs)
 * A bevitt szövegben megkeresi először az igét (Verb)
 * Aztán megnézi, hogy csak az ige feltételt kielégíti-e bármelyik sor
 * - HA IGEN: akkor elmenti egy ideiglenes parancstömbbe az aktuálisan passzoló sort
 * - HA NEM: akkor tovbb keres, most már az alannyal
 * Aztán megnézi megint, hogy van-e olyan parancssor ami ki teljesen kielégíti a feltételeket
 * - HA IGEN: akkor elmenti egy ideiglenes parancstömbbe az aktuálisan passzoló sort
 * - HA NEM: akkor tovbb keres
 * és így tovább, majd pedig megnézi a következő mondatrészt amiben állítmányt talált
 * 
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Respiration_SpeechControl_v01_00
{
    public partial class Main : Form
    {

        //DECLARATION
        // SOR,OSZLOP!
        string[,] CmdArrayStatic = new string[100, 30];
        string[,] CmdArrayDinamic = new string[100, 30];
        int CmdArrayDinamicLenght = 0;

        //DECLARATION

        public Main()
        {
            InitializeComponent();
            LoadCommands(@"Data\Commands.txt", Convert.ToChar(9), CmdArrayStatic);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            Interception.StartListening();

            txbContents.Text = Interception.ReturnValue + Environment.NewLine;

        
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Interception.StopListening();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(true)
            {
                try
                {
                    MessageBox.Show(CmdManager.FormatMessage(txbMessage.Text)[i]);
                    i++;
                }
                catch
                {
                    break;
                }
            }   // ameddig tartanak a tömb elemei jelenítse meg őket messageboxban
        }

        private void btnLoadCommands_Click(object sender, EventArgs e)
        {
            string[] String = CmdManager.FormatMessage(txbMessage.Text);
            CmdArrayDinamic = TextInColumn(CmdArrayStatic, String, 2);
            CmdArrayDinamic = TextInColumn(CmdArrayDinamic, String, 7);
            FillDgvWithArray(dgvCommands, CmdArrayStatic);
            FillDgvWithArray(dgvCommandsDynamic, CmdArrayDinamic);
            MessageBox.Show(CmdArrayDinamicLenght.ToString());

        }
        // COMMAND MANAGER FÜGGVÉNYEK

        // Vissza ad egy fileból egy táblát, amit a delimiter szerint oszlopokra oszt, aztán egy stringtömbbe rendezi az adatokat
        // Legyen úgy, hogy csak visszaadja a tömböt, aztán majd azt betöltetjük a datagridviewba
        private DataTable LoadCommands (string FilePath, char Delimiter, string [,] CmdArrayStatic)
        {
            StreamReader file = new System.IO.StreamReader(FilePath);
            string[] columnnames = file.ReadLine().Split(Delimiter);
            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }
            string newline;
            
            int Row = 0;
            while ((newline = file.ReadLine()) != null)
            {

                DataRow dr = dt.NewRow();
                string[] values = newline.Split(Delimiter);
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                    CmdArrayStatic[Row, i] = values[i];
                }
                dt.Rows.Add(dr);
                Row++;

            }
            file.Close();
            return dt;

        }
        /*
        private string[,] FindVerb(string[,] CmdArrayStatic, string[] Sentence, int VerbColumn)
        {
            string[,] FormatedArray = new string[100, 30];
            int Row = 0;
            // végigmegy a szavakon
            for(int i = 0; Sentence.Length>i;i++)
            {
                // végigmegy a parancstábla sorain
                for(int j = 0; CmdArrayStatic[j, VerbColumn]!=null; j++)
                {
                    if(Sentence[i]== CmdArrayStatic[j, VerbColumn])
                    {
                        for(int k = 0;k<30;k++)
                        {
                            FormatedArray[Row, k] = CmdArrayStatic[j, k];
                        }
                        Row++;
                    }
                }
                CmdArrayDinamicLenght = Row;
            }
            
            return FormatedArray;
        }
        private string[,] FindSubject(string[,] CmdArrayDynamic, string[] Sentence, int SubjectbColumn)
        {
            string[,] FormatedArray = new string[100, 30];
            int Row = 0;
            // végigmegy a szavakon
            for (int i = 0; Sentence.Length > i; i++)
            {
                // végigmegy a parancstábla sorain
                for (int j = 0; CmdArrayStatic[j, SubjectbColumn] != null; j++)
                {
                    if (Sentence[i] == CmdArrayStatic[j, SubjectbColumn])
                    {
                        for (int k = 0; k < 30; k++)
                        {
                            FormatedArray[Row, k] = CmdArrayStatic[j, k];
                        }
                        Row++;
                    }
                }
                CmdArrayDinamicLenght = Row;

            }

            return FormatedArray;
        }
        */
        private string[,] TextInColumn(string[,] CmdArrayDynamic, string[] Sentence, int SubjectbColumn)
        {
            /*
                A bemenő string[,] tömb adott oszlopában megkeresi a string[] összes elemét, majd visszatér a találatok teljes sorával
            */
            #region Paraméterek
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //ha igaz, törli a parancsmondatból a talált szót
            bool deleteResult = false;
            //beírt sorok száma
            int Row = 0;
            //beírt sorban lévő parancsszavak száma, amit beír a sor végére (30-as oszlopba)
            int Hits = 0;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion

            string[,] FormatedArray = new string[100, 30];
            // végigmegy a szavakon
            for (int i = 0; Sentence.Length > i; i++)
            {
                // végigmegy a parancstábla sorain
                for (int j = 0; CmdArrayDynamic[j, SubjectbColumn] != null; j++)
                {
                    if (Sentence[i] == CmdArrayDynamic[j, SubjectbColumn])
                    {
                        //végigmegy a találat oszlopain
                        for (int k = 0; k < 30; k++)
                        {
                            if(deleteResult && (k==SubjectbColumn)){} else
                            {
                                FormatedArray[Row, k] = CmdArrayDynamic[j, k];
                            }

                            //Szavak számlálása
                            if(CmdArrayDynamic[j, k]!=""&&CmdArrayDynamic[j, k] != null)
                            { Hits++; }
                        }

                        Row++;
                    }
                    FormatedArray[j, 29] = Hits.ToString();
                    Hits = 0;
                }
                CmdArrayDinamicLenght = Row;

            }

            return FormatedArray;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void FillDgvWithArray (DataGridView Dgv, string[,] Array)
        {
            Dgv.Rows.Clear();
            int height = Array.GetLength(0);
            int width = Array.GetLength(1);

            Dgv.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Dgv);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = Array[r, c];
                }

                Dgv.Rows.Add(row);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillDgvWithArray(dgvCommands, CmdArrayStatic);
            FillDgvWithArray(dgvCommandsDynamic, CmdArrayDinamic);
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            string[] String = CmdManager.FormatMessage(txbMessage.Text);
        }
    }
}
