using System;
using System.IO;
using System.Collections.Generic;
namespace SlipegFramework
{
    public static class GeneralUtillity
    {
        public static void CreateChangelog(List<string>ChangeLogList, string ProjectName, string projectVersion, string Date)
        {
            int ChangeSize = ChangeLogList.Count;
            string StartMessage = $"//Changelog for the version: {projectVersion} of {ProjectName} project. -{Date}- //";
            using (StreamWriter Changes = new StreamWriter(Environment.CurrentDirectory+"\\"+$"{ProjectName}-{projectVersion}.txt"))
            {
                Changes.WriteLine(StartMessage);
                Changes.WriteLine("New-Features");
                for (int i = 0; i < ChangeSize; i++)
                {
                    Changes.WriteLine(i+"."+ChangeLogList[i]);
                }
            }
        }
        public static void CreateChangelog(List<string> ChangeLogList,List<string>KnownBugs, string ProjectName, string projectVersion, string Date)
        {
            int ChangeSize = ChangeLogList.Count;
            int BugsSize = KnownBugs.Count;
            string StartMessage = $"//Changelog for the version: {projectVersion} of {ProjectName} project. -{Date}- //";
            using (StreamWriter Changes = new StreamWriter(Environment.CurrentDirectory +"\\"+ $"{ProjectName}-{projectVersion}.txt"))
            {
                Changes.WriteLine(StartMessage);
                Changes.WriteLine("New-Features:");
                for (int i = 0; i < ChangeSize; i++)
                {
                    Changes.WriteLine(i + "." + ChangeLogList[i]);
                }
                Changes.WriteLine("Known-bugs:");
                for (int i = 0; i < BugsSize; i++)
                {
                    Changes.WriteLine(i + "." + KnownBugs[i]);
                }
            }
        }
        private static bool CheckForBadChars(string Line,char[] ForbiddenChars)
        {
            char[] ArrLine = Line.ToCharArray();
            int ArrLineLength = ArrLine.Length;
            bool IsForbidden = false;

            for (int a = 0; a < ArrLineLength; a++)
            {
                for (int b = 0; b < ForbiddenChars.Length; b++)
                {
                    if (ArrLine[a] == ForbiddenChars[b])
                    {
                        IsForbidden = true;
                        return IsForbidden;
                    }
                }
            }
            return IsForbidden;
        }
        public static bool IsDigit(string MyString)
        {
            bool IsDig = false;
            char[] MyStringConverted = MyString.ToCharArray();
            for (int i = 0; i<MyStringConverted.Length; i++)
            {
                if(!char.IsDigit(MyStringConverted[i]) || MyStringConverted[i].Equals('.')) 
                {
                    IsDig = true;
                    continue;
                }
                else
                {
                    IsDig = false;
                    break;
                }
            }
            return IsDig;
        }
    }
}
