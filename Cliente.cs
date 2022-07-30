using System;

namespace Leccion2doParcial
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Dispositivo { get; set; }
        

        public Cliente(string Nombre, string Dispositivo)
        {
            this.Nombre = Nombre;
            this.Dispositivo = Dispositivo;
           
        }

        public void OrdenReparacion()
        {
            Console.WriteLine("Nombre del Cliente: " + Nombre);
            Console.WriteLine("Dispositivo a reparar: " + Dispositivo);
            
        }
    }
}