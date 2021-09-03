using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;

        }

        public short GetTinta()
        {
            return this.tinta;

        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta; //vuelve el numero siempre en positivo, le suma lo que ingreses

            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }

        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo) // out para utilizar el valor por referencia devuelve dibujo
        {
            dibujo = "";
            short aux;

            if (this.tinta > 0) //tiene tinta?
            {
                if(gasto > this.tinta) // 10 > 2 -> le asigno tinta, gasto todo
                {
                    aux = this.tinta; // gasto todo lo que hay 
                }
                else
                {
                    aux = gasto; 
                }

                for(int i = 0; i < aux; i++)
                {
                    dibujo += "*";
                }
                SetTinta((short)-gasto);
                return true;
            }
            return false; 
            
        }




    }
}
