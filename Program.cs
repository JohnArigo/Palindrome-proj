using System;

namespace project1
{
    class program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            do
            {
                Console.WriteLine("Desired word check");
                string s = Console.ReadLine();
                int decider;
                var checkItems = check(s);
                if (checkItems.Item2)
                {
                    Console.WriteLine($"It works, length is {checkItems.Item1}");
                    Console.WriteLine("Keep going? 1 yes or 2 no");
                    string decidertring = Console.ReadLine();
                    decider = Int32.Parse(decidertring);
                    if (decider == 2)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine($"It failed, length is {checkItems.Item1}");
                    Console.WriteLine("Keep going? 1 yes or 2 no");
                    string decidertring = Console.ReadLine();
                    decider = Int32.Parse(decidertring);
                    if (decider == 2)
                    {
                        Environment.Exit(0);
                    }
                }
            } while (keepGoing);
        }

        static Tuple<int, bool> check(string s)
        {
            string compareS = s;
            char[] charArray2 = compareS.ToCharArray();
            foreach (char c in charArray2)
            {
                if (!char.IsPunctuation(c))
                {
                    charArray2.Append(c);
                }
            }
            string upperedString = compareS.ToUpper();
            //original string manipulation
            char[] charArray = s.ToCharArray();
            foreach (char c in charArray)
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    charArray.Append(c);
                }
            }
            Array.Reverse(charArray);
            string newS = new string(charArray);
            string newSUppered = newS.ToUpper();
            Console.WriteLine(newSUppered);

            if (newSUppered == upperedString)
            {
                return Tuple.Create(s.Length, true);
            }
            else
            {
                return Tuple.Create(s.Length, false);
            }
        }
    }
}
