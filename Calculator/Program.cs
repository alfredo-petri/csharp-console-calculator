namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Sum();
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 + value2;

            Console.WriteLine($"O resultado da operação é {result}");
            
            Console.WriteLine("");
        }
    }
}