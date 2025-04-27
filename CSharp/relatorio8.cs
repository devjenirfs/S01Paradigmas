using System;

class Cachorro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Cachorro(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void MostrarNome()
    {
        Console.WriteLine($"O nome do cachorro é: {Nome}");
    }

    public virtual void ShowIdade()
    {
        Console.WriteLine($"A idade do cachorro é: {Idade} anos");
    }
}

class CachorroPequeno : Cachorro
{
    public CachorroPequeno(string nome, int idade) : base(nome, idade) { }

    public override void ShowIdade()
    {
        Console.WriteLine($"(Cachorro Pequeno) A idade é: {Idade} anos");
    }
}

class CachorroGrande : Cachorro
{
    private string tamanho;

    public CachorroGrande(string nome, int idade, string tamanho) : base(nome, idade)
    {
        this.tamanho = tamanho;
    }

    public string Tamanho
    {
        get { return tamanho; }
    }

    public override void ShowIdade()
    {
        Console.WriteLine($"(Cachorro Grande) A idade é: {Idade} anos e o tamanho é: {tamanho}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando os objetos
        Cachorro cachorroNormal = new Cachorro("Rex", 5);
        CachorroPequeno cachorroPequeno = new CachorroPequeno("Bolinha", 2);
        CachorroGrande cachorroGrande = new CachorroGrande("Thor", 7, "Grande");

        // Imprimindo atributos e métodos de cada objeto
        Console.WriteLine("\nCachorro Normal:");
        cachorroNormal.MostrarNome();
        cachorroNormal.ShowIdade();

        Console.WriteLine("\nCachorro Pequeno:");
        cachorroPequeno.MostrarNome();
        cachorroPequeno.ShowIdade();

        Console.WriteLine("\nCachorro Grande:");
        cachorroGrande.MostrarNome();
        cachorroGrande.ShowIdade();
        Console.WriteLine($"Tamanho: {cachorroGrande.Tamanho}");
    }
}
