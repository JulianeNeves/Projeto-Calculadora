using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_Calculadora
{
    internal class Program
    {
        enum Menu { Soma=1, Subtracao, Multiplicacao, Divisao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair)
            {
                //desenvolvendo o menu
                Console.WriteLine("Calculadora, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Multipicacao\n4-Divisao\n5-Potencia\n6-Raiz\n7-Sair");
                //Menu opcao = (Menu)int.Parse(Console.ReadLine());
                string opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt; //esse codigo é a mesma coisa do de cima

                switch(opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                            Subtração();
                        break;

                    case Menu.Multiplicacao:
                        Mult();
                        break;

                    case Menu.Divisao:
                        Div();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();
                
            }
            
        }
       static void Soma()
        {
           
            Console.WriteLine("Soma de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2;

            Console.WriteLine("O resultado dessa conta é: "+resultado);
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtração()
        {

            Console.WriteLine("Subtração de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 - num2;

            Console.WriteLine("O resultado dessa conta é: " + resultado);
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Mult()
        {

            Console.WriteLine("Multiplicação de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 * num2;

            Console.WriteLine("O resultado dessa conta é: " + resultado);
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Div()
        {

            Console.WriteLine("Divisão de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            float resultado = (float)num1/(float)num2;

            Console.WriteLine("O resultado dessa conta é: " + resultado);
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia()
        {

            Console.WriteLine("Potencia de um numero:");
            Console.WriteLine("Digite a base da potencia: ");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            double resultado = Math.Pow(basenum,expoente);

            Console.WriteLine("O resultado dessa conta é: " + resultado);
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {

            Console.WriteLine("Raiz de um numero:");
            Console.WriteLine("Digite o numero: ");
            int num1 = int.Parse(Console.ReadLine());

           double resultado = Math.Sqrt(num1);

            Console.WriteLine("O resultado dessa conta é: " + resultado);
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

    }
}
