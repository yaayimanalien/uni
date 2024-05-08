// See https://aka.ms/new-console-template for more information
using ConsoleTables;

// using ConsoleTables;
using System;
using ConsoleTables;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var table = new ConsoleTable("one", "two", "three");
        table.AddRow(1, 2, 3)
            .AddRow("this line should be longer", "yes it is", "oh");

        table.Write();
        Console.WriteLine();

        var rows = Enumerable.Repeat(new Something(), 10);

        ConsoleTable.From<Something>(rows)
            .Configure(o => o.NumberAlignment = Alignment.Right)
            .Write(Format.Alternative);

        Console.ReadKey();
    }
}

public class Something
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }

    public Something()
    {
        // Default constructor
    }

    public Something(int id, string name, double value)
    {
        Id = id;
        Name = name;
        Value = value;
    }
}
