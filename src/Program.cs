namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            var number = Convert.ToInt32(Console.ReadLine());
            var ones = number % 10;
            var teens = number % 1000 % 100 / 10;
            var hundreds = number % 1000 / 100;
            var sauthens = number / 1000;
            var result = ones + teens + hundreds + sauthens;
            Console.WriteLine(result);

        }
    }
}
