using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil
    {
        
        public int velocidadActual;
        public Marca marca;

        #region Constructores
        public Automovil()
            :this(1)
        {}
        public Automovil(int velcidadInicial)
        {
            this.velocidadActual = velcidadInicial;
        }
        public Automovil(string velcidadInicial)
              : this (int.Parse(velcidadInicial))
        {  }

        public Automovil(string marca, int velcidadInicial)
          // : this(new Marca(marca)), velcidadInicial)
        {
          //  this.marca = marca;
        }

        public Automovil(Marca marca, int velcidadInicial)
            :this (velcidadInicial)
        {
            this.marca = marca;
        }

        #endregion
        
        
        
        ///// <summary>
        ///// alecera en 1 a la vez
        ///// </summary>
        //public void Acelerar() {

        //    this.velocidadActual++;
        //}

        ///// <summary>
        ///// acelera dependiendo de cuanto le ingreses
        ///// </summary>
        ///// <param name="incremento"></param>
        //public void Acelerar(int incremento)
        //{

        //    this.velocidadActual += incremento;
        //}




      //  public static bool operator
        public static Automovil operator +(Automovil a, int incremento)
        {
            a.velocidadActual += incremento;
            return a;
        }

        public static bool operator == (Automovil a, int velocidad)
        {
            return a.velocidadActual == velocidad;

        }
        public static bool operator != (Automovil a, int velocidad)
        {
            return !(a == velocidad);

        }


        public static explicit operator int (Automovil a)
        {
            return a.velocidadActual;
        }

    }

}
