using System;
using static System.Console;

namespace school_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName = "Code Academy",
                   schoolColors = "#63B1E5 (Pantone 292)";
            int studentPopulation = 1000000;
            WriteLine(WriteStars(72));
            WriteLine(WriteInfo("School name:", schoolName));
            WriteLine(WriteInfo("No. of students:", String.Format("{0:N0}", studentPopulation)));
            WriteLine(WriteInfo("School colors:", schoolColors));
            WriteLine(WriteStars(72));
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

        static string WriteInfo(string label, string value)
        {
            string result = string.Empty;
            result += WriteStars(2);
            result += String.Format("{0, 32} {1, 32}", label, value);
            result += "   ";
            result += WriteStars(2);
            return result;
        }
    }
}
