using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Respiration_SpeechControl_v01_00
{
    public static class Interception
    {
        public static string ReturnValue;

        public static SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public static PromptBuilder promptBuilder = new PromptBuilder();
        public static SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine();
        public static Choices cList = new Choices();

        public static void StartListening()
        {
            // Start
            cList.Add(new string[] { "hello", "hallo" });
            Grammar grammar = new Grammar(new GrammarBuilder(cList));
            try
            {
                recognitionEngine.RequestRecognizerUpdate();
                recognitionEngine.LoadGrammar(grammar);
                recognitionEngine.SpeechRecognized += RecognitionEngine_SpeechRecognized;
                recognitionEngine.SetInputToDefaultAudioDevice();
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                ReturnValue=(ex.Message);
            }

        }

        public static void StopListening()
        {
            recognitionEngine.RecognizeAsyncStop();
            ReturnValue = "";
        }

        private static void RecognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "hello":

                    break;

            }

            ReturnValue = e.Result.Text.ToString() + Environment.NewLine;
        }
    }
}
