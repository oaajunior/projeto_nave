using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] carro;
            carro = new int[2];
            carro[0] = 1;
            carro[1] = 2;

            int[] carr1 = { 2, 4, 5 };

            int[ , ] matriz;
            matriz = new int[2,1];

            int[,] mat = { {2, 1 }, {3, 2 } };
            int[] mat2 = { 2, 6 };
             char a  = Console.ReadKey().KeyChar;
            Console.WriteLine(a);
            Console.ReadKey();
           
            

        }
    }
}
