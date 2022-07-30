using System;

namespace Leccion2doParcial {
public class Schip : Decorador2
{
    public Schip (DispositivoBase orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.Write("Chip: ");
        var Chip = base.Add() + "Si";
        
        return Chip;
    }
}
}