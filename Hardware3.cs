using System;

namespace Leccion2doParcial {
public class Hardware3 : Decorador1
{
    public Hardware3(DispositivoBase orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.WriteLine("Se añade PowerBank");
        var Adiccion = base.Add();
        
        return Adiccion;
    }
}
}