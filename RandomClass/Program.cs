internal class Program
{

    private static void Main(string[] args)
    {
        Console.Write("Type the number of doubles to generate: ");
        string line = Console.ReadLine();

        /*while (line != null)
        {
            if (int.TryParse(line))
        }*/
        
        Random random = new Random();
        double[] randomDoubles = new double[20]; //sub in 20 for parsed int read from line
        for (int i = 0;i < randomDoubles.Length; i++)
        {
            double value = random.NextDouble();
            randomDoubles[i] = value;
            Console.WriteLine(value.ToString("0.00"));
        }
        Console.WriteLine("There are " + randomDoubles.Length + " doubles randomly generated.");
    }
}