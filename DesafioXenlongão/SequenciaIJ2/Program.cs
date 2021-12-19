using System;

class DIO
{

    static void Main(string[] args)
    {

        for (int I = 1; I <= 9; I += 2)
        {
            for (int J = 7; J >= 5; J--)   
            {
                Console.WriteLine($"I={I} J={J}");
            }
        }
    }

}