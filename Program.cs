using System;
using static System.Console;

namespace school_info
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(WriteStars(42));
        }

        static string WriteStars(int reps)
        {
            string result = string.Empty;
            for (int i = 0; i < reps; i++)
            {
                result += String.Format("*");
            }
            return result;
        }
    }
}
