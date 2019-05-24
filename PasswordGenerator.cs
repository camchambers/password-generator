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

        public string GeneratePassword()
        {
            var randomNumberGenerator = new RNGCryptoServiceProvider();

            // The number of characters in the password that will be generated
            int passwordSize = 8;

            // Lower bound value of unicode table for generating a character
            int lowerBound = 63;

            // Upper bound value of unicode table for generating a character
            int upperBound = 122;

            // A random integer derived from our random number byte array
            uint randomInt = 0;

            // C# string defaults to the UTF-16 encoding of Unicode, 
            // which is 2 bytes
            // We create a random number array of 2 bytes in size
            byte[] randomNumber = new byte[4];

            // A string builder object for storing our password
            StringBuilder passwordBuffer = new StringBuilder();

            // Generate random characters as many times as the length of 
            // the password to generate
            for (int i = 0; i < passwordSize; i++)
            {

                // Fill the randomNumber byte array with random numbers 
                randomNumberGenerator.GetBytes(randomNumber);

                // System.BitConverter.ToUInt32 Returns a 32-bit unsigned 
                // integer converted from four bytes at a specified position 
                // in a byte array.
                randomInt = System.BitConverter.ToUInt32(randomNumber, 0);

                // Scale the result between min and max
                int scaledResult = (int)(randomInt % (upperBound - lowerBound)) + lowerBound;

                // Convert the scaled integer value to a character
                char resultChar = (char)scaledResult;

                // Add our character to the password buffer
                passwordBuffer.Append(resultChar);

            }

            // RNGCryptoServiceProvider implements the IDisposable interface
            // and should be disposed of when finished with it 
            randomNumberGenerator.Dispose();

            return passwordBuffer.ToString();

        }

    }

}