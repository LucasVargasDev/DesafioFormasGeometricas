using System;

public class Circulo : Forma
{
    public double Raio { get; set; }

    public Circulo(string nome, double raio) : base(nome)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public override string ToString()
    {
        return "Circulo - Nome: " + base.Nome + " Raio: " + Raio + " Area: " + CalcularArea();
    }
}