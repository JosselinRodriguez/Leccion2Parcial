using System;

namespace Leccion2doParcial
{
    public abstract class Dispositivo
    {
    public int IMEI {get; set;}
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public string Sistema {get; set;}
    public string Pais {get; set;}
    public string funcionalidad1 {get; set;}
    public string funcionalidad2 {get; set;}
    public string funcionalidad3 {get; set;}

    public Dispositivo(int IMEI, string Marca, string Modelo, string Sistema, string Pais, string funcionalidad1, string funcionalidad2, string funcionalidad3)
    { 
        this.IMEI = IMEI;
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Sistema = Sistema;
        this.Pais = Pais;
        this.funcionalidad1 = funcionalidad1;
        this.funcionalidad2 = funcionalidad2;
        this.funcionalidad3= funcionalidad3;
    }

    public abstract void Funcionabilidad();

    public abstract void Imprimir();

    }
}