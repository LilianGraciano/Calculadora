using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    internal class Program
    {
        enum Menu { Soma = 1, Sub, Div, Multi, Pot, raiz, Sair }

        static void Main(string[] args)

        {
            bool escolherSair = false;

            while(!escolherSair)
            {
               
                
                Console.WriteLine("Seja bem vindo a nossa CALC.\n\nEscolha uma opção\n");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7--Sair--");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
             

                switch (opcao)
                {
                
                    case Menu.Soma:
                        Soma();
                        break;
                   

                    case Menu.Sub:
                        Sub();
                        break;

                    case Menu.Div:
                        Div();
                        break;

                    case Menu.Multi:
                        Multi();
                        break;

                    case Menu.Pot:
                        Potencia();
                        break;

                    case Menu.raiz:
                        Raiz();
                            break;

                    case Menu.Sair:
                        escolherSair = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("FIM DE EXECUÇÃO.");
                        break;


                }

                Console.Clear();

            }

            static void Soma ()
            {
                Console.WriteLine("Digite a soma dos dois números:\n");
                Console.WriteLine("Digite o primeiro número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                int b = int.Parse(Console.ReadLine());

                int resultado = a + b;
      
                Console.WriteLine($"O resultado da soma é:{resultado}\n");
                Console.WriteLine("Aperte ENTER para voltar pro MENU:");
                Console.ReadLine();

            }

            static void Sub()
            {
                Console.WriteLine("Digite a subtração dos dois números:\n");
                Console.WriteLine("Digite o primeiro número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                int b = int.Parse(Console.ReadLine());
                

                int resultado = a - b;

                Console.WriteLine($"O resultado da subtração é:{resultado}\n");
                Console.WriteLine("Aperte ENTER para voltar pro MENU:");
                Console.ReadLine();

            }

            static void Div()
            {
                Console.WriteLine("Digite a Divisão dos dois números:\n");
                Console.WriteLine("Digite o primeiro número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                int b = int.Parse(Console.ReadLine());

                float resultado = (float)a/(float)b;

                Console.WriteLine($"O resultado da Divisão é:{resultado}\n");
                Console.WriteLine("Aperte ENTER para voltar pro MENU:");
                Console.ReadLine();
               

            }

            static void Multi()
            {
                Console.WriteLine("Digite a Multiplicação dos dois números:\n");
                Console.WriteLine("Digite o primeiro número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                int b = int.Parse(Console.ReadLine());

                float resultado = (float)a * (float)b;

                Console.WriteLine($"O resultado da Multiplicação é:{resultado}\n");
                Console.WriteLine("Aperte ENTER para voltar pro MENU:");
                Console.ReadLine();


            }

            static void Potencia()
            {
                Console.WriteLine("Potência de um número:\n");
                Console.WriteLine("Digite a base:");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente:");
                int expo = int.Parse(Console.ReadLine());

                int resultado = (int) Math.Pow(baseNum, expo);

                Console.WriteLine($"O resultado da Multiplicação é:{resultado}\n");
                Console.WriteLine("Aperte ENTER para voltar pro MENU:");
                Console.ReadLine();


            }

            static void Raiz()
            {
                Console.WriteLine("Raiz de um número:\n");
                Console.WriteLine("Digite o número:");
                int a = int.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a);

                Console.WriteLine($"O resultado da é:{resultado}\n");
                Console.WriteLine("Aperte ENTER para voltar pro MENU:");
                Console.ReadLine();




            }
            Console.Clear();
            

        }
    }
}
