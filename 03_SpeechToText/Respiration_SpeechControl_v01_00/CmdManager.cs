 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respiration_SpeechControl_v01_00
{
    public static class CmdManager
    {


        public static string[] FormatMessage(string Message)
        {
            string[] MsgArray = Message.ToLower().Trim().Split(' ').ToArray();
            
            return MsgArray;
        }
    }
}
