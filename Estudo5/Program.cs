namespace Estudo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i / 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if (i / 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if ((i / 3 == 0) && (i / 3 == 0))
                {
                    Console.WriteLine("FizzBuzz.");
                }
            }

            Console.WriteLine($"O calculo é: {FuncaoSort(4)}");
        }

        static int FuncaoSort(int x)
        {
            int calculo = 0;
            calculo = x ^ 2;
            return calculo;
        }
    }
}
