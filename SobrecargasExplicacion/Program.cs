using System;
using Entidades;
namespace SobrecargasExplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Automovil au = new Automovil(10);
            Automovil au1 = new Automovil(24);
            // au.Acelerar();
            //au.Acelerar();

            Console.WriteLine(au.velocidadActual);


            //ES PARA EVALUAR CONDICIONES 
            Console.WriteLine(au == 10);
            Console.WriteLine(au == 13  ? "SI" : "NO");
            Console.WriteLine("CARRO 2 ");

            Console.WriteLine(au1.velocidadActual);
            Console.WriteLine(au1 == 10);
            Console.WriteLine(au1 == 13 ? "SI" : "NO");



        }
    }
}
