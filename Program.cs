// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Clear();
            char r = 'n';

            do
            {

                Console.WriteLine("Digite a operação que deseja");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(" + Adição\n - Subtração\n * multiplicação\n / para divisão");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
                Char op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Soma();
                        break;
                    case '-':
                        Subtracao();
                        break;
                    case '*':
                        multiplicacão();
                        break;
                    case '/':
                        divisao();
                        break;

                }

                Console.WriteLine("\n");

                Console.WriteLine("\n Quer fazer uma nova operção ? Digite y sim, n para não");

                r = char.Parse(Console.ReadLine());
            } while (r == 'y');




        }
        static void Soma()
        {

            Console.WriteLine("primeiro valor ");
            float n1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo numero");
            float n2 = float.Parse(Console.ReadLine());


            float resu;
            resu = n1 + n2;
            Console.WriteLine($"O resultado da soma dos dois numero é: {resu}");

        }

        static void Subtracao()
        {

            Console.WriteLine("primeiro valor ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            float n2 = float.Parse(Console.ReadLine());


            float resu;
            resu = n1 - n2;
            Console.WriteLine($"O resultado da soma dos dois numero é: {resu}");

        }

        static void multiplicacão()
        {

            Console.WriteLine("primeiro valor ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            float n2 = float.Parse(Console.ReadLine());


            float resu;
            resu = n1 * n2;
            Console.WriteLine($"O resultado da soma dos dois numero é: {resu}");

        }

        static void divisao()
        {

            Console.WriteLine("primeiro valor ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            float n2 = float.Parse(Console.ReadLine());


            float resu;
            resu = n1 / n2;
            Console.WriteLine($"O resultado da soma dos dois numero é: {resu}");

        }
    }


}