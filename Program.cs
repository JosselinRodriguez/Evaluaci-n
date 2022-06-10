using System;
namespace leccion
{
class program
{
    static void Main (string[]args)
{
    cuadradof cuadrado = new cuadradof ("cuadrado", "cafe", 5,5,5,5);
    cuadrado.imprimir();
    cuadrado.Calcular();
    rectangulof ractangulo = new rectangulof ("amarillo", "verde", 6,7);
    rectangulo.imprimir();
    rectangulo.Calcular();
    circulof circulo = new circulof ("circulo", "celeste", 5,4);
    circulo.imprimir();
    circulo.Calcular();
    List<Figura> listaFigura= new List<Figura>
            listaFigura.Add(cuadradof);
            listaFigura.Add(rectangulof);
            listaFigura.Add(circulof);

            foreach(Figura item in listaFigura)
            {
                item.imprimir();
            }
}      }  
}