using System.Runtime.CompilerServices;

public class Livro
{
    public string? Titulo;
    public Autor? Autor;
    public double Preco;

    public Livro(string titulo, Autor autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
    public Livro(string titulo, Autor autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public void mostrarInfo()
    {
        Console.WriteLine($"O título do livro é {Titulo}, seu autor é {Autor.Nome} e custa {Preco}");
    }

    public void aplicarDesconto(double Valor)
    {
        Preco -= Preco * (Valor / 100);
    }
    public void aplicarDesconto(int Valor)
    {
        Preco = Preco - Valor;
    }
}