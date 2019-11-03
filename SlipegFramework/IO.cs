using System;
using System.Collections.Generic;
using System.IO;
namespace SlipegFramework
{
    public static class IO
    {
        public enum TypeValue { IntValue=0, BoolValue,FloatValue,DecimalValue,StringValue};
        public static void WriteToBinary(string Location, string FileName,object Data)
        {
            using (BinaryWriter brw = new BinaryWriter(File.Open(Location + "\\"+FileName, FileMode.OpenOrCreate)))
            {
                var DataTypeValue = Data;
                if (DataTypeValue.GetType().Equals(typeof(int)))
                {
                    brw.Write((int)DataTypeValue);
                }
                else if (DataTypeValue.GetType().Equals(typeof(bool)))
                {
                    brw.Write((bool)DataTypeValue);
                }
                else if (DataTypeValue.GetType().Equals(typeof(float)))
                {
                    brw.Write((float)DataTypeValue);
                }
                else if (DataTypeValue.GetType().Equals(typeof(decimal)))
                {
                    brw.Write((decimal)DataTypeValue);
                }
                else if (DataTypeValue.GetType().Equals(typeof(string)))
                {
                    brw.Write((string)DataTypeValue);
                }
                else
                {
                    throw new InvalidDataException();
                }
                brw.Close();
                brw.Dispose();
            }
        }
        public static object ReadToBinary(string Location, string FileName, TypeValue TpVal)
        {

            using (BinaryReader brr = new BinaryReader(File.Open(Location + "\\" + FileName, FileMode.Open)))
            {
                if (TpVal.Equals(TypeValue.IntValue))
                {
                    int ValueToReturn = 0;
                    ValueToReturn = brr.ReadInt32();
                    brr.Dispose();
                    return ValueToReturn;
                }
                else if (TpVal.Equals(TypeValue.BoolValue))
                {
                    bool ValueToReturn = false;
                    ValueToReturn = brr.ReadBoolean();
                    return ValueToReturn;
                }
                else if (TpVal.Equals(TypeValue.FloatValue))
                {
                    float ValueToReturn = 0.0f;
                    ValueToReturn = brr.ReadSingle();
                    return ValueToReturn;
                }
                else if (TpVal.Equals(TypeValue.DecimalValue))
                {
                    decimal ValueToReturn = 0m;
                    ValueToReturn = brr.ReadDecimal();
                    return ValueToReturn;
                }
                else if (TpVal.Equals(TypeValue.StringValue))
                {
                    string ValueToReturn = string.Empty;
                    ValueToReturn = brr.ReadString();
                    return ValueToReturn;
                }
                else
                {
                    throw new InvalidDataException();
                }
               
            }
        }
        public static void WriteToTxt(string LocationAndName,string Line,bool Append)
        {
            using (StreamWriter sw = new StreamWriter(LocationAndName, Append))
            {
                sw.WriteLine(Line);
            }
        }
        public static string ReadFromTxt(string LocationAndName, bool Append)
        {
            string line = "";

            using (StreamReader sr = new StreamReader(LocationAndName, Append))
            {
                line = sr.ReadLine();
            }
            return line;
        }
        
        public static void WriteToTxt(string LocationAndName, List<string> Lines, bool Append)
        {
            using (StreamWriter sw = new StreamWriter(LocationAndName, Append))
            {
                for (int i = 0; i < Lines.Count; i++)
                {
                    sw.WriteLine(Lines);
                }
            }
        }
    }
}
