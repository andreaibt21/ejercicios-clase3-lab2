using System;
using Entidades;
namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
           string dibujito1,  dibujito2;

            //instanciamos boligrafos
            Boligrafo b1 = new Boligrafo(0, ConsoleColor.Blue);
            Boligrafo b2 = new Boligrafo(0, ConsoleColor.Red);


            //B1
            //llamo pintar pero no funcionará porque no tiene tinta 

            if ( !b1.Pintar(12, out dibujito1))
            {
                Console.WriteLine("notiene tinta");
            }
            //recargo la tinta 
            b1.Recargar();

            if (!b1.Pintar(12, out dibujito1))
            {
                Console.WriteLine("no tiene tinta");
            }

            //seteamos el color
            Console.ForegroundColor = b1.GetColor();
            Console.WriteLine(dibujito1);
        }
    }
}
