using System;

public abstract class Forma
{
    public string Nome { get; set; }

    public Forma(String nome)
    {
        Nome = nome;
    }

    public abstract double CalcularArea();

    public override abstract string ToString();
}