using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of iterations:");
        if (int.TryParse(Console.ReadLine(), out int iterations) && iterations > 0)
        {
            double piApproximation = CalculatePi(iterations);
            Console.WriteLine($"Approximation of Pi after {iterations} iterations: {piApproximation}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the number of iterations.");
        }
    }

    static double CalculatePi(int iterations)
    {
        Random random = new Random();
        int insideCircle = 0;

        for (int i = 0; i < iterations; i++)
        {
            double x = random.NextDouble();
            double y = random.NextDouble();

            double distance = Math.Sqrt(x * x + y * y);

            if (distance <= 1)
            {
                insideCircle++;
            }
        }

        return 4.0 * insideCircle / iterations;
    }
}
