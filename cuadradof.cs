using System.Runtime.Intrinsics.Arm.Arm64;
using System.Globalization;
using System;
namespace leccion
{
class cuadradof : Figura
{
    public int lado {get; set;}
    public int lado2 {get; set;}
    public int lado3 {get; set;}
    public int lado4 {get; set;}
    public cuadradof (string nombre, string color, int lado, int lado2, int lado3, int lado4 ); Base(nombre;color)
    {
        this.lado=lado;
        this.lado2=lado2;
        this.lado3=lado3;
        this.lado4=lado4;
    }
    public override void Calcular()
    {
     int=Area=0;
     resultado=lado+lado2+lado3+lado4;
     Console.WriteLine("El area del cuadrado es "+ );

    }
    }
}
