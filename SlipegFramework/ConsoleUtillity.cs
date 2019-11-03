using System;
using System.Collections.Generic;


namespace SlipegFramework
{
    public class ConsoleUtillity
    {
        private Random RandomColor = new Random(Guid.NewGuid().GetHashCode());
        public ConsoleColor ChoseRandomColor()
        {
            ConsoleColor ReturnedValue = ConsoleColor.White;
            switch (RandomColor.Next(0, 7))
            {
                case 0:
                    ReturnedValue = ConsoleColor.Blue;
                    break;
                case 1:
                    ReturnedValue = ConsoleColor.Cyan;
                    break;
                case 2:
                    ReturnedValue = ConsoleColor.Yellow;
                    break;
                case 3:
                    ReturnedValue = ConsoleColor.DarkGreen;
                    break;
                case 4:
                    ReturnedValue = ConsoleColor.DarkYellow;
                    break;
                case 5:
                    ReturnedValue = ConsoleColor.Magenta;
                    break;
                case 6:
                    ReturnedValue = ConsoleColor.Red;
                    break;
                case 7:
                    ReturnedValue = ConsoleColor.White;
                    break;
            }
            return ReturnedValue;
        }
    }
}
