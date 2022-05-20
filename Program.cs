using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresar un numero: ");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresar un Numero: ");
                int Num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Num1 / Num2);
                Console.ReadLine();

            }
               catch(System.DivideByZeroException e) //System.Exception -- DivideByZeroException e -- FormatException e
            {
                Console.Write(e.Message); //"Error" -- e.Message
            }

            Console.ReadKey();
        }
           
        
    }
}
