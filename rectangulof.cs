using System.Globalization;
using System;
namespace leccion
{
class rectangulof : Figura
public int Base {get; set;}
public int altura {get; set;}
public rectangulof (string nombre, string color , int Base , int altura); Base (nombre , color )
{
    this.Base=Base;
    this.altura=altura;
}
 public override void Calcular()
 {
  resultado=Base*altura;
  Console.WriteLine("El area del rectangulo es  " + resultado );
 }
}