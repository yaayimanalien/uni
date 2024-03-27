using System;

public class Product
{
    public string name;
    public double price;

    public void Register()
    {
        Console.Write("Enter product name: ");
        name = Console.ReadLine();
        Console.Write("Enter product price: ");
        price = double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine($"Product Name: {name}, Price: {price}");
    }
}

public class Cart
{
    public int number;
    public Product[] products;

    public void Register()
    {
        Console.Write("Enter the number of items in the cart: ");
        number = int.Parse(Console.ReadLine());
        products = new Product[number];
        for (int i = 0; i < number; i++)
        {
            products[i] = new Product();
            Console.WriteLine($"Enter details for item {i + 1}:");
            products[i].Register();
        }
    }

    public double Total()
    {
        double totalAmount = 0;
        foreach (Product product in products)
        {
            totalAmount += product.price;
        }
        return totalAmount;
    }

    public void Output()
    {
        Console.WriteLine("Items in the cart:");
        foreach (Product product in products)
        {
            product.Output();
        }
        Console.WriteLine($"Total amount: {Total()}");
    }
}

public class Person
{
    public string name;
    private string password;
    public Cart cart;
    public double funds;

    public void Register()
    {
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your password: ");
        password = Console.ReadLine();
        Console.Write("Enter available funds: ");
        funds = double.Parse(Console.ReadLine());
        cart = new Cart();
        Console.WriteLine("Registering items in the cart:");
        cart.Register();
    }

    public bool EnoughFunds()
    {
        return funds >= cart.Total();
    }

    public void Output()
    {
        Console.WriteLine($"Person Name: {name}, Funds: {funds}");
        cart.Output();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Register();
        Console.WriteLine();
        person.Output();
        Console.WriteLine();
        if (person.EnoughFunds())
        {
            Console.WriteLine("You have enough funds.");
        }
        else
        {
            Console.WriteLine("You don't have enough funds.");
        }
    }
}
