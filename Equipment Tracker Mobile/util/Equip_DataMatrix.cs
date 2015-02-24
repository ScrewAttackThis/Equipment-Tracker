using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentTracker.util
{
    class Equip_DataMatrix
    {
        private string[] parsedDataString;

        public Equip_DataMatrix(string rawDataString)
        {
            //Remove not needed characters: [, ), >, <RS> and <EOT>
            char[] removeChars = new char[] {Convert.ToChar("["), Convert.ToChar(")"), Convert.ToChar(">"), Convert.ToChar(4), Convert.ToChar(30)};
            rawDataString = rawDataString.Trim(removeChars);
            //Splits raw data by <GS> ASCII control character (Char(29)
            parsedDataString = rawDataString.Split(Convert.ToChar(29));

            //Removes Data Indentifiers from elements

            for(int i = 0; i < parsedDataString.Rank; i++)
            {
                if (parsedDataString[i].StartsWith("17V"))
                    parsedDataString[i].Remove(0, 3);
                else if (parsedDataString[i].StartsWith("1P") | parsedDataString[i].StartsWith("1M"))
                    parsedDataString[i].Remove(0, 2);
                else if (parsedDataString[i].StartsWith("S"))
                    parsedDataString[i].Remove(0, 1);
            }
        }

        public string MFR
        {
            get { return parsedDataString[1]; }
            set { parsedDataString[1] = value; }
        }
        public string PartNumber
        {
            get { return parsedDataString[2]; }
            set { parsedDataString[2] = value; }
        }
        public string SerialNumber
        {
            get { return parsedDataString[3]; }
            set { parsedDataString[3] = value; }
        }
        public string MACAddress
        {
            get { return parsedDataString[4]; }
            set { parsedDataString[4] = value; }
        }
    }
}
