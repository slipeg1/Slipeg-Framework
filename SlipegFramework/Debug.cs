using System;
using System.IO;
using System.Collections.Generic;


namespace SlipegFramework
{
    public class Debug
    {
        private List<string> DebugTraces = new List<string>();
        public void AddTrace(string Trace,string line,string WorkingObject)
        {
            DebugTraces.Add("["+DateTime.Now+"]: "+Trace+" "+WorkingObject+" "+"Line["+line+"]");
        }
        public void AddTrace(string Trace, string line, string WorkingObject, string Class)
        {
            string MyClassName = Class;
            DebugTraces.Add("[" + DateTime.Now + "]: " + Trace + " " + WorkingObject.ToString() + $"[{MyClassName}]" + " " + "Line[" + line + "]");
        }
        public void AddTrace(string Trace, string line, string WorkingObject, string Class, bool IsList, int Length)
        {
            string MyClassName = Class;
            DebugTraces.Add("[" + DateTime.Now + "]: " + Trace + " " + WorkingObject + $"[{MyClassName}]" + $"[{Length}]" + " " + "Line[" + line + "]");
        }
        public void PrintTraces()
        {
            foreach (string line in DebugTraces)
            {
                Console.WriteLine(line);
            }
        }
        public void WriteLogs(string Location, string FileName)
        {
            using (StreamWriter sw = new StreamWriter(Location +"\\"+FileName, true))
            {
                for (int i = 0; i<DebugTraces.Count; i++)
                {
                    sw.WriteLine(DebugTraces[i]);
                }
            }
        }
    }
}
