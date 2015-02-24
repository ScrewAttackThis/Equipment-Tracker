using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentTracker.util
{
    class Functions
    {
        public static int CountOccurencesOfChar(string searchString, char searchChar)
        {
            int result = 0;
            foreach (char curChar in searchString)
            {
                if (searchChar == curChar)
                {
                    ++result;
                }
            }

            return result;
        }
    }
}
