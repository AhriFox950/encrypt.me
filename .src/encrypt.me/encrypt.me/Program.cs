using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is the main namespace.
/// </summary>
namespace encrypt.me
{
    /// <summary>
    /// This is the main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method is used for initilazation.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            // Try to convert to an float.
            float a;
            if (float.TryParse(args[1], out a)) { }
            Data.fillData(a);

            Key key = new Key();
  
            Console.WriteLine(Logic.GetEncryptedString(args[0], (a)));
        

        }
    }

    /// <summary>
    /// This is the *main* class for the program. It will hold all of the logic functions.
    /// </summary>
    class Logic
    {
        public static string GetEncryptedString(string raw, float key)
        {
            return RawToEnc(raw, key);
        }

        /// <summary>
        /// This method will convert raw data, into an incrypted string.
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public static string RawToEnc(string raw, float key)
        {
            // First, setup the prefix and the suffex (random numbers)
            Random rnd = new Random();
            string pre = rnd.Next(999).ToString().PadLeft(3, '0');
            string suf = rnd.Next(999).ToString().PadLeft(3, '0');
            string toReturn = "";
            char[] a = { '-' };

            // Init the database.
            Data.fillData(key);

            foreach (char c in raw)
            {
                toReturn += Data.database[c];
                toReturn += '-';
            }

            toReturn = toReturn.Remove(toReturn.Length - 1);


            return toReturn;
        }
    }

    /// <summary>
    /// This class is used to store the key.
    /// </summary>
    class Key
    {
        private int _key;
        public int key
        {
            get { return _key; }
            set
            {
                if (_key > 0 || _key < 999)
                {
                    throw new Exception("Out of key range");                
                }
                else
                {
                    _key = value;
                }
            }
        }
    }

}
