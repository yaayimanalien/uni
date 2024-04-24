using System;

class Pirmais
{
    public Pirmais()
    {
        Console.WriteLine("Tiek izveidots Pirmais objekts");
    }

    ~Pirmais()
    {
        Console.WriteLine("Pirmais objekts tiek iznīcināts");
    }
}

class Otrais : Pirmais
{
    public Otrais()
    {
        Console.WriteLine("Tiek izveidots Otrais objekts");
    }

    ~Otrais()
    {
        Console.WriteLine("Otrais objekts tiek iznīcināts");
    }
}

class Tresais : Otrais
{
    public int x;
    public Tresais()
    {
        Console.WriteLine("Tiek izveidots Tresais objekts");
    }

    ~Tresais()
    {
        Console.WriteLine("Tresais objekts tiek iznīcināts");
    }
}

static class Program
{
    static void Main(string[] args)
    {
        Init();
        GC.Collect();
        Console.ReadLine();
    }
    
    public static void Init()
    {
        Tresais tresais = new Tresais();
    }

}