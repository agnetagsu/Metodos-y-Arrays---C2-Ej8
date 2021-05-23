using System;

namespace Metodos_y_Arrays___C2_Ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray = new int[50];
            
            for (int i=0;i<miarray.Length;i++)
            {
                miarray[i] = i;
                Console.WriteLine(miarray[i]);
            }

            
        }
    }
}
