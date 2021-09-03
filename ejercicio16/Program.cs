using System;
using Entidades;
namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno Alumno1 = new Alumno("Andrea","Briceño", 123);
            Alumno Alumno2 = new Alumno("Jorge", "Caceres", 323);
            Alumno Alumno3 = new Alumno("Victoria", "Figueira", 123);

            Alumno1.Estudiar(3, 3);
            Alumno2.Estudiar(5, 6); 
            Alumno3.Estudiar(7, 8);

            Alumno1.CalcularFinal();

            Console.WriteLine(Alumno1.Mostrar());





        }
    }
}
