﻿namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("");
            Console.Write("Selecione a opção desejada: ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: Exit(); break;
                default: Menu(); break;
            }
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

            EndOfOperation();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 - value2;

            Console.WriteLine($"O resultado da operação é {result}");

            Console.WriteLine("");

            EndOfOperation();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 * value2;

            Console.WriteLine($"O resultado da operação é {result}");

            Console.WriteLine("");

            EndOfOperation();
        }
        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = value1 / value2;

            Console.WriteLine($"O resultado da operação é {result}");

            Console.WriteLine("");

            EndOfOperation();
        }
        static void EndOfOperation()
        {
            Console.Write("pressione alguma tecla para retornar ao menu: ");
            Console.ReadKey();
            Menu();
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar esta aplicação.");
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
}