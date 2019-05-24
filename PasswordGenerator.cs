// The System namespace contains fundamental classes and base classes that 
// define commonly-used value and reference data types, events and event 
// handlers, interfaces, attributes, and processing exceptions.
using System;

// The System.Security.Cryptography namespace provides cryptographic services, 
// including secure encoding and decoding of data, as well as many other 
// operations, such as hashing, random number generation, and authentication
using System.Security.Cryptography;

// The System.Text namespace contains classes that represent ASCII and Unicode 
// character encodings; abstract base classes for converting blocks of 
// characters to and from blocks of bytes; and a helper class that manipulates 
// and formats String objects without creating intermediate instances of String.
using System.Text;

namespace password_generator
{
    class PasswordGenerator
    {
        private string passwordCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFG" +
                  "HIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()-_=+[]{}\\|;:'\",<" +
                  ".>/?";

        public PasswordGenerator()
        {
            Console.WriteLine("Password generator loaded.");
            var rng = new RNGCryptoServiceProvider();
        }

        public string Generate()
        {
            return string.Empty;
        }

        public char randomCharacter()
        {
            return '0';
        }

    }

}