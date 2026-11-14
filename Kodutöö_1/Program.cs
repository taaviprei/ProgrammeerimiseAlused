namespace Kodutöö_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ComputerNumber = 5;
            int UserNumber = 0;
            while (ComputerNumber != UserNumber)
            {
                Console.WriteLine("Enter your guess (from 1 - 10): ");
                UserNumber = Convert.ToInt32(Console.ReadLine());
                if (ComputerNumber == UserNumber)
                {
                    Console.WriteLine("You guessed correctly, congratulations!");
                }
                else if (ComputerNumber > UserNumber)
                {
                    Console.WriteLine("The number is bigger");
                }
                else
                {
                    Console.WriteLine("The number is smaller");
                }
            }
        }
    }
}
