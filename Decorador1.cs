using System;

namespace Leccion2doParcial {
public class Decorador1 : DispositivoBase
{
    protected DispositivoBase orden;
    public Decorador1 (DispositivoBase orden)
    {
        this.orden = orden;
    }
    public override string Add()
    {
        //Console.WriteLine("Calculo del precio total desde la clase decorador");
        return orden.Add();
    }
    }
    }