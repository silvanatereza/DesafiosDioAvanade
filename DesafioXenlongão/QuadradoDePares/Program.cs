
using System;

class DIO
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int cont = 1; cont <= n; cont++)
        {
            if (cont % 2 == 0)
            {

                Console.WriteLine($"{cont}^{2} = {Math.Pow(cont, 2)}");
            }

        }

    }

}