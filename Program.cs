using System;

namespace password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new password generator object
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Generate a password using the password generator
            string password = passwordGenerator.GeneratePassword();

            // Display the password
            Console.WriteLine(password);
        }
    }
}
