using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encrypt.me
{
    class Data
    {

        public static List<char> a = new List<char>(){ 'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z',
            ' ',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            '0'
           };


        public static Dictionary<char, float> database = new Dictionary<char, float>();

        /// <summary>
        /// This method will fill out the data.
        /// </summary>
        public static void fillData(float key)
        {
            char[] newChar = a.ToArray();

            for (int i = 0; i < newChar.Length; i++)
            {
                try
                {
                    database.Add(newChar[i], keyFinal(i, key));
                }
                catch { }
            }
        }

        public static float keyFinal (int index, float key)
        {
            return ((index * index) + (index * 2) + ((key * key) / (2)));
        }
    }
}
