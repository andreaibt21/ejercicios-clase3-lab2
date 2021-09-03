using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace clase3
{
    public class Program
    {
       static void Main( string[] args) 
       {
            Persona p1 = new Persona("Ale", 25);
            Persona p2 = new Persona("Andrea", 25);
            Persona p3 = new Persona("Jose", 25);
            Persona p4 = p3;

            p1.SetNombre("paola");
            Console.WriteLine("{0} tiene {1} años y es {2}", p1.GetNombre(), p1.GetEdad(), p1.GetTipo());
            Console.WriteLine("{0} tiene {1} años y es {2}", p2.GetNombre(), p2.GetEdad(), p2.GetTipo());
            Console.WriteLine("{0} tiene {1} años y es {2}", p3.GetNombre(), p3.GetEdad(), p3.GetTipo());
            Console.WriteLine("{0} tiene {1} años y es {2}", p4.GetNombre(), p4.GetEdad(), p4.GetTipo());
        }
    }
}
