using System;

namespace Leccion2doParcial {
public class Decorador2 : BaseChip
{
    protected DispositivoBase orden;
    public Decorador2 (DispositivoBase orden)
    {
        this.orden = orden;
    }
    public override string Add()
    {
        Console.WriteLine("Calculo total desde la clase decorador");
        return orden.Add();
    }
}
}