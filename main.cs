using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Apresentação das Formas");

      List<Forma> formas = new List<Forma>();

      formas.Add(new Quadrado("Alfa", 2.0));
      formas.Add(new Circulo("Beta", 5.0));
      formas.Add(new Triangulo("Charlie", 3.0, 3.0, 3.0));

      foreach(Forma forma in formas) {
        Console.WriteLine(forma.ToString());
      }
    }
}