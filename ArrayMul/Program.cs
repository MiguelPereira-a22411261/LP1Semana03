using System;
using System.Globalization;
using System.Reflection;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
           CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
           
           float [,] matrix = new float[2,2];
           matrix [0,0] = float.Parse(args[0]);
           matrix [0,1] = float.Parse(args[1]);
           matrix [1,0] = float.Parse(args[2]);
           matrix [1,1] = float.Parse(args[3]);

           float[] matrix2 = new float[2];
           matrix2 [0] = float.Parse(args[4]);
           matrix2 [1] = float.Parse(args[5]);

           float[] endMatrix = new float[2];

           for (int val1 = 0; val1 < matrix.GetLength(0); val1++)
           {
                endMatrix[val1] = 0;
                for (int val2 = 0; val2 < matrix.GetLength(0); val2++)
                {
                    endMatrix[val1] += matrix[val1, val2] * matrix2[val2];
                }
           }
           foreach (float value in endMatrix)
           {
                Console.WriteLine($"| {value, 7:f2} |");
           }
        }
    }
}
