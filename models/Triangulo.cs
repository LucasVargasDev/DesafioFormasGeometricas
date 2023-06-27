using System;
using System.Collections.Generic;

public class Triangulo : Forma
{
    public List<double> Lados = new List<double>(2);

    public Triangulo(string nome, double lado1, double lado2, double lado3) : base(nome)
    {
        Lados.Add(lado1);
        Lados.Add(lado2);
        Lados.Add(lado3);
    }

    public override double CalcularArea()
    {
        double perimetro = (Lados[0] + Lados[1] + Lados[2]) / 2;
        return Math.Sqrt(perimetro * (perimetro - Lados[0]) * (perimetro - Lados[1]) * (perimetro - Lados[2]));
    }

    public override string ToString()
    {
        return "Triangulo - Nome: " + base.Nome + " Area: " + CalcularArea();
    }
}