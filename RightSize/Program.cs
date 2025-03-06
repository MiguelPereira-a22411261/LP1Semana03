using System;
using System.Text;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length > 3 && s.Length < 8)
                    {
                        Console.WriteLine(s);
                    }
                else if (s.Length >= 8)
                    {    
                        Console.WriteLine("[EARLY STOP]");
                        break;
                    }
            }

        }
    }
}
