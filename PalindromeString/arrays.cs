using System;
namespace ArrayName
{
    class Arrays
    {
        void LearnArrays()
        {
            int[] ages1 = new int[10];
            double[] ages2 = new double[10];
            ages1[0] = 14;
            ages1[1] = 13;

            float[] numbers = new float[] { 23.4f, 43.4f, 12.5f, 45.1f, 67.2f };
            float[] numbers1 = new float[] { 21.4f, 23.4f, 11.5f, 15.1f, 100.2f };

        }
        //learn 1D arrays
        void Learn1DArray()
        {
            //2-D array
            int[,] agesMatrix = new int[10, 15];
            agesMatrix[0, 0] = 4567;
            int[,,] qgeMatrix3D = new int[10, 15, 5];
            string[,] names = new string[,] { { "sushil", "Ghimire" }, { "Dipan", "B.K" } };
            string[,] names1 = new string[,] { { "sushil", "Ghimire" }, { "Sushant", "Sarki" } };


        }
       //lagged array
       void LearnLaggedArray()
       {
           byte[][] personAges = new byte[3][];
           personAges[0]=new byte[]{34,56};
           personAges[1]=new byte[]{34,56,44,56};
           personAges[2]=new byte[]{34,56,2};
       } 

    }
}