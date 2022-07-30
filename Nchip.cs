using System;

namespace Leccion2doParcial {
public class Nchip : Decorador2
{
    public Nchip (DispositivoBase orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.Write("Chip: ");
        var Chip = base.Add() + "No";
        
        return Chip;
    }
}
}