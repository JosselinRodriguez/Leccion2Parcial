using System;

namespace Leccion2doParcial
{
    public class Tablet : Dispositivo
    {
        
    public Tablet(int IMEI, string Marca, string Modelo, string Sistema, string Pais, string funcionalidad1, string funcionalidad2, string funcionalidad3) : base(IMEI, Marca, Modelo, Sistema, Pais, funcionalidad1, funcionalidad2, funcionalidad3)
    { 
        /*
        this.IMEI = IMEI;
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Sistema = Sistema;
        this.Pais = Pais;
        this.funcionalidad1 = funcionalidad1;
        this.funcionalidad2 = funcionalidad2;
        this.funcionalidad3= funcionalidad3;
        */
    }

    public override void Funcionabilidad()
    {
        Console.WriteLine("Funcionalidades: ");
        Console.WriteLine("1: " + funcionalidad1);
        Console.WriteLine("2: " + funcionalidad2);
        Console.WriteLine("3: " + funcionalidad3);
    }

    public override void Imprimir()
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Dispositivo a reparar:");
        Console.WriteLine("------------------");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("IMEI: " + IMEI);
        Console.WriteLine("Sistema Operativo: " + Sistema);
        //Console.WriteLine("Hardware Adicional: " + hardware);
        Console.WriteLine("------------------");
    }
    }
}