using System;

namespace Leccion2doParcial {
public class Hardware2 : Decorador1
{
    public Hardware2(DispositivoBase orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.WriteLine("Se añade Cargador");
        var Adiccion = base.Add();
        
        return Adiccion;
    }
}
}