using System;

namespace Entidades

{
    public class Persona

    {
        private string nombre;
        private int edad;
        public static string tipo;

        static Persona()
        {
            Persona.tipo = "Humano";
        }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void SetNombre(string nombre)
        {
             this.nombre = nombre;
        }
        public string GetNombre(){
            return this.nombre;
        }
        public int GetEdad()
        {
            return this.edad;
        }
        public string GetTipo()
        {
            return Persona.tipo;

        }
        public static bool AlterarObjetoRecibido(Persona p4)
        {
            //if ( !(p4 is null) )
            if (!object.ReferenceEquals(p4,null)) {
                p4.nombre = "Alterado";
                return true;
            }
            return false;
        
                
        }
    }
}
