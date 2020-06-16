
using System;
using System.Security.Cryptography;
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
