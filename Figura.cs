using System.Globalization;
using System;
abstract class Figura
{
    public string nombre {get ; set ;}
    public string color {get ; set ;}
    public Figura {string nombre , string color }
    {
        this.nombre=nombre;
        this.color=color;
    }
    public abstract void imprimir()
    {
        Console.WriteLine("nombre"+nombre);
        Console.WriteLine("color"+color);
    }
}