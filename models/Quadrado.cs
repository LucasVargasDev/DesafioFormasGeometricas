using System;

public class Quadrado : Forma
{
    public double Lado { get; set; }

    public Quadrado(string nome, double lado) : base(nome)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override string ToString()
    {
        return "Quadrado - Nome: " + base.Nome + " Lado: " + Lado + " Area: " + CalcularArea();
    }
}