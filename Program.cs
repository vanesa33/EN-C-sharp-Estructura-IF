using System;

namespace estructura_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //estructura if

            byte juan = 20, pedro = 19, jorge = 25;

            if (juan > pedro)
            {
                if (jorge > juan)
                {
                    Console.WriteLine("jorge es el mayor de todos");

                }
            }

            Console.ReadKey();

           




        }
    }
}
