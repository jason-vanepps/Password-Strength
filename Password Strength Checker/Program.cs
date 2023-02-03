using System;

namespace PasswordChecker
{
    public class Tools
    {
        public Tools()
        {
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static void ContainsTest()
        {
            string loudWord = "LASDAD";
            string quietWord = "pssst";
            string mixedWord = "lkaAWEkasfkEW";

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Running \"tests...\"");
            Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
            Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
            Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
        }
        class Program
        {
            public static void Main(string[] args)
            {

                Console.WriteLine("Enter a password: ");
                string password = Console.ReadLine();
                int score = 0;

                if (password.Length > 8)
                {
                    score++;
                }
                if (Tools.Contains(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
                {
                    score++;
                }
                if (Tools.Contains(password, "abcdefghijklmnopqrstuvwxyz"))
                {
                    score++;
                }
                if (Tools.Contains(password, "1234567890"))
                {
                    score++;
                }
                if (Tools.Contains(password, "!@#$%^&*()_-+={[}]|:;<,>.?`~"))
                {
                    score++;
                }
                Console.WriteLine($"Your password strength is: {score}");
                Console.ReadLine();



            }
        }
    }
}