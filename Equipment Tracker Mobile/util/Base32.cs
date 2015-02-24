using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentTracker.util
{
    public class Base32
    {        
        public static long base32ToLongInt(string base32Number)
        {
            char[] base32 = new char[]
            {
                '0','1','2','3','4','5','6','7','8',
                '9','a','b','c','d','e','f','g','h',
                'i','j','k','l','m','n','o','p','q',
                'r','s','t','u','v'
            };
            long n = 0;
            foreach (char d in base32Number.ToLower())
            {
                n = n << 5;
                int idx = Array.IndexOf(base32, d);

                if (idx == -1)
                    throw new Exception("Provided number contains invalid characters");

                n += idx;
            }

            return n;
        }
    }
}
