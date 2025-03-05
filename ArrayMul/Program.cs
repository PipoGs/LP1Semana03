using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float[,] matrixA = new float[2, 2];

            matrixA[0, 0] = float.Parse(args[0]);
            matrixA[0, 0] = float.Parse(args[1]);
            matrixA[0, 0] = float.Parse(args[2]);
            matrixA[0, 0] = float.Parse(args[3]);

            float[] vectorB = new float[2];

            vectorB[0] = float.Parse(args[4]);
            vectorB[1] = float.Parse(args[5]);

            float[] total = new float[2];

            for (int i = 0; i < 2; i++)
            {
                total[i] = 0;

                for (int j = 0; j < 2; j++)
                {
                    total[i] += matrixA[i, j] * vectorB[j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(total[i]);
            }
        }
    }
}
