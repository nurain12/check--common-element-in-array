using System;

namespace CommonElementInArray
{
class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 1, 2, 3, 4, 5 };
            int[] arrayB = { 3, 2, 9, 3, 7 };

            for (int i = 0; i < arrayA.Length; i++)
            {
                for(int j = 0; j < arrayB.Length; j++) 
                { 
                    if(arrayA[i] == arrayB[j])
                    {
                        Console.WriteLine(arrayA[i]);
                    }
                }
            }
        }
     }
}

