using System;

namespace Leccion2doParcial {
public class Hardware1 : Decorador1
{
    public Hardware1(DispositivoBase orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.WriteLine("Se añade Audifono");
        var Adiccion = base.Add();
        
        return Adiccion;
    }
}
}