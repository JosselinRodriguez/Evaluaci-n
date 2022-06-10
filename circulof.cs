using System.Globalization;
using System;
namespace leccion
{
class circulof : Figura
public double pI=Math.PI();
public double R= Math.Paw(R2,2);
public circulof (string nombre, string color , double pI , double R); Base (nombre , color )
{
    this.pI=pI;
    this.R=R;
}
 public override void Calcular()
 {
  resultado=pI*R;
  Console.WriteLine("El area del circulo es  " + resultado );
 }
}

