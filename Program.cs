using System;

namespace PruebaP1
{
    public class Program
    {
        public static void Main(string[] arg)
        {

        var C1 = new Cliente("Cliente 1", "Tablet");

        var T1 = new Tablet(12345,"Samsung","T51","Android","Corea de Sur","Pantalla","Camara","Procesador");

        C1.OrdenReparacion();

        var H1 = new Hardware1(T1);
        Console.WriteLine(H1.Add());

        var CHIP = new Tablet(H1);
        Console.WriteLine(CHIP.MostrarChip());

        T1.Imprimir();
        Console.WriteLine(); 

        }
    }
}

            Celular celular = new Celular(098650,"iphone", "14", "ios", "EEUU","cargador","pantalla", "botones de sonido", "camara de fotos");
            Tablet tablet = new Tablet(0678930,"Samsung", "A13", "android", "EEUU","cargador","audio", "botones de sonido", "camara de fotos");
            Tablet tablet = new Tablet(0234560,"Huawei", "3000lite", "android", "CHINA","cargador","pantalla", "botones de sonido", "camara de fotos");
            Ciente cliente1 = new Cliente("Jose Rodriguez", "Celular", "cambio de pantalla");
            Cliente cliente2 = new Cliente("Javier Medina", "Tablet", "arreglo de audio");
            Cliente cliente3 = new Cliente("MAlejandro Mera", "Tablet", "cambio de pantalla");

 
 
 
            List<Dispositivo> lista1 = new List<Dispositivo>();
            lista1.Add(celular);
            lista1.Add(tablet);

            foreach(Dispositivo lista2 in lista1){
                lista2.imprimir();
                lista2.funcionalidades();
                }
            List<Cliente> lista3 = new List<Cliente>();
            lista3.Add(cliente);
            lista3.Add(cliente2);

            foreach(Cliente lista4 in lista3){
                lista4.ordenReparacion();
            }

            List<Dispositivos> lista1 = new List<Dispositivos>();
            lista1.Add(celular);
            lista1.Add(tablet);

            foreach(Dispositivo lista2 in lista1){
                lista2.imprimir();
                lista2.funcionalidades();
            }

            foreach(chip lista5 in lista1){
                lista5.mostrarChip();

                
            }
     
