using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Alumno
    {
        public string apellido;
        public string nombre;
        public int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            
        }
        /// <summary>
        /// asigna las notas 1 y 2 al alumno
        /// </summary>
        /// <param name="notaUno"></param>
        /// <param name="notaDos"></param>
        public void Estudiar(byte notaUno, byte notaDos) 
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal() 
        {
            Random random = new Random();
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(4,10);
            }
            else {
                this.notaFinal = -1;
            }
        }

        public string Mostrar() 
        {
            if (this.notaFinal == -1)
            {
               return string.Format("{0} {1} tiene el legajo {2}, nota1 {3}, nota2 {4} y el alumno está desaprobado",
                                    this.nombre, this.apellido, this.legajo, this.nota1, this.nota2);
            }
             return string.Format("{0} {1} tiene el legajo {2}, nota1 {3}, nota2 {4} y su nota final es {5}",
                                  this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, this.notaFinal);

        /*
        if (this.notaFinal == -1)
        {
             final = "Alumno desaprobado";
        }
        else {
            final = string.Format("{0}",this.notaFinal);
        }

          datos = string.Format(  "{0} {1} tiene el legajo {2}, nota1 {3}, nota2 {4} y su nota final es {5}", 
                                this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, final);

        return datos;*/

    }



    }
}
