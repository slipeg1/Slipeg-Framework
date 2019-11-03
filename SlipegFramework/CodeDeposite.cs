using System;
using System.Collections.Generic;
using System.Threading;


namespace SlipegFramework
{
    public class CodeDeposite
    {
        private List<Random> RdmList = new List<Random>();
        private char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string Output;
        public void Matrix(int Delay, int Size)
        {
            FillMatrixVall(Size);
            while (true)
            {
                Output = "";
                Thread.Sleep(Delay);
                for(int i = 0; i < RdmList.Count; i++)
                {
                    Random rdm1 = new Random(Guid.NewGuid().GetHashCode());
                    int result = rdm1.Next(0,100);
                    if (result > 10)
                    {
                        Output += RdmList[i].Next(0, 9);
                    }
                    else
                    {
                        Output += Alphabet[rdm1.Next(0, Alphabet.Length)].ToString().ToUpper();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Output);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        private void FillMatrixVall(int Size)
        {
            for(int i = 0; i<Size; i++)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                RdmList.Add(r);
            }
        }
    }
}
