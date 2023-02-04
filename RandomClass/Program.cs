internal class Program
{
    static Random random = new Random();
    private static void Main(string[] args)
    {
        Console.Write("Type the number of doubles to generate: ");
        string line = Console.ReadLine();
        string m = "exit";

        //while loop to run program until exited
        while (line.ToString() != "0")
        {
            //Parse and loop utilized from PickRandomCards
            if (int.TryParse(line, out int n))
            {
                double[] randomDoubles = new double[n];
                for (int i = 0; i < randomDoubles.Length; i++)
                {
                    //generation of doubles
                    double value = random.NextDouble();
                    randomDoubles[i] = value;
                    Console.WriteLine(value.ToString("0.00"));
                }
                Console.WriteLine("There are " + randomDoubles.Length + " doubles randomly generated.");
                Console.Write("\nEnter another amount to generate or 'exit': ");
                string last = Console.ReadLine();

                //sets result true for any case of 'exit'
                bool result = string.Equals(last, m, StringComparison.CurrentCultureIgnoreCase);
                if (result == true)
                {
                    Console.Write("\nThank you for experimenting with the Random class! \nGoodbye");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                line = last;
                continue;
            }
            else
            {
                Console.Write("You entered a string, please enter an integer:");
                line = Console.ReadLine();
            }
        }
    }
}