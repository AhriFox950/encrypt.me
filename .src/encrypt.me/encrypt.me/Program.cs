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
            // Call the main logic method with the command line arguments.
            Key key = new Key();
            int _key = 1;
            if (int.TryParse(args[0], out _key))
            {
                
            }
        }
    }

    /// <summary>
    /// This is the *main* class for the program. It will hold all of the logic functions.
    /// </summary>
    class Logic
    {
        public void Encrypt(string raw)
        {

        }

        /// <summary>
        /// This method will convert raw data, into an incrypted string.
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public string RawToEnc(string raw, int key)
        {
            // First, setup the prefix and the suffex (random numbers)
            Random rnd = new Random();
            string pre = rnd.Next(999).ToString().PadLeft(3, '0');
            string suf = rnd.Next(999).ToString().PadLeft(3, '0');
            return "";
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
