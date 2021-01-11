using System;

namespace C_NET_Test
{
    class SortMassive
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] massive = new int[size];
            //massive[0] = 10;
            //massive[0] = 1;
            //massive[0] = 5;
            //massive[0] = 3;
            //massive[0] = 6;
            for (int i = 0; i < massive.Length; i++)
                massive[i] = i * i;
            int[] NewMassive = GetMaxValue(massive, ref size);
            PrintMassive(NewMassive);
        }
        public static int[] GetMaxValue(int[] MethodMassive, ref int size)
        {
            int temp = 0;
            for (int x = 0; x < MethodMassive.Length; x++)
                for (int z = 0; z < MethodMassive.Length; z++)
                    if (MethodMassive[x] > MethodMassive[z])
                    {
                        temp = MethodMassive[x];
                        MethodMassive[x] = MethodMassive[z];
                        MethodMassive[z] = temp;
                    }
            return MethodMassive;
        }
        public static void PrintMassive(int[] PrintMassive)
        {
            for (int i = 0; i < PrintMassive.Length; i++)
                Console.WriteLine("Massive is sorted: {0}", PrintMassive[i]);
            Console.ReadKey();
            return;
        }
    }
}
