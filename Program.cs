using System;

namespace Calculadora;

internal class Program
{
    enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
    static void Main(string[] args)
    {
        bool escolheuSair = true;
        while (escolheuSair)
        {
            Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");
            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            Console.WriteLine(opcao);
            switch (opcao)
            {
                case Menu.Sair:
                    escolheuSair = false;
                    break;

                case Menu.Soma:
                    Somar();
                    break;

                case Menu.Subtracao:
                    Subtracao();
                    break;

                    case Menu.Divisao:
                        Divisao();
                    break;

                case Menu.Multiplicacao:
                    Multiplicacao();
                    break;

                case Menu.Potencia:
                    Potencia();
                    break;
                    case Menu.Raiz:
                    Raiz();
                    break;

            }
            Console.Clear();
        }
        static void Somar()
        {
            Console.WriteLine("Você está somando");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O Resultado da soma é {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Você está subtraindo");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O Resultado da substração é {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Você está dividindo");
            Console.WriteLine("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine($"O Resultado da divisão é {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Você está multiplicando");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O Resultado da multiplicação é {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Você está potenciando");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O Resultado da potencia é {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Você está raiz");
            Console.WriteLine("Digite o número: ");
            int raiz = int.Parse(Console.ReadLine());
            double resultado = (int)Math.Sqrt(raiz);
            Console.WriteLine($"O Resultado da raiz é {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
    }
}