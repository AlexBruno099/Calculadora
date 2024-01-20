using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class program
    {

        public static void Main()
        {
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("3- Divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());


            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = Adicao(num1, num2);
                    break;

                case 2:
                    resultado = Subtracao(num1, num2);
                    break;

                case 3:
                    resultado = Multiplicacao(num1, num2);
                    break;

                case 4:
                    resultado = Divisao(num1, num2);
                    break;
                default:
                    Console.WriteLine("O número inserido é incorreto!");
                    break;


            }
            Console.WriteLine("Resultado da operação entre os números {0} e {1} é {2}", num1, num2, resultado);
            Console.ReadLine();
        }
        public static int Adicao(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static int Divisao(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}

