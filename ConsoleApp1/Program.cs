using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int menu;

            Console.WriteLine(" 1-Contagem regressiva");
            Console.WriteLine(" 2-Tabuada");
            Console.WriteLine(" 3-Soma dos numeros");
            Console.WriteLine(" 4-Adivinhe um numero");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                int contador= 1 ;
                Console.WriteLine("Voce Selecionou a Opção 1");
                Console.WriteLine("Escolha um n*");
                int escolha_do_user = int.Parse(Console.ReadLine());

                while (contador <= escolha_do_user)
                {
                    Console.WriteLine(contador);
                    contador++;

                }

            }
            else if (menu == 2) 
            {
                Console.WriteLine("Voce Selecionou a Opção 2");

                int total;
                int tabu = 1  ;
                
                
                Console.WriteLine("Escolha um n*");
                int escolha = int.Parse(Console.ReadLine());
                
                Console.WriteLine("O numero selecionado foi " + escolha);
                Console.WriteLine("\n");

                while (tabu <= 10)
                {
                    total = escolha * tabu;
                    escolha = escolha * 1 ;
                    Console.WriteLine(escolha + " x " + tabu +" = "+total );
                    

                    tabu++;

                    
                }
            }
            else if( menu == 3) 
            {
                Console.WriteLine("Voce Selecionou a Opção 3");

                int soma = 0;
                int contador = 1;
                int quantidade;

                Console.WriteLine("\n");

                Console.WriteLine("Digite a quantidade de numeros a serem somados");
                quantidade = int.Parse(Console.ReadLine());

                while (contador <= quantidade) 
                {
                    contador++;
                    Console.WriteLine("insira os numeros");
                    soma += int.Parse(Console.ReadLine());
                }
                

                Console.WriteLine("a soma dos numeros digitados eh = " + soma);
            }
            else if ( menu == 4) 
            {
                Console.WriteLine("Voce Selecionou a Opção 4");

                Random random = new Random();
                int numeroAleatorio = random.Next(1, 101);
                int tentativas = 0;
                int palpite;

                Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
                Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

                do
                {
                    Console.Write("Digite seu palpite: ");
                    if (int.TryParse(Console.ReadLine(), out palpite))
                    {
                        tentativas++;

                        if (palpite < numeroAleatorio)
                        {
                            Console.WriteLine("Palpite muito baixo. Tente novamente.");
                            Console.WriteLine("\n");
                        }
                        else if (palpite > numeroAleatorio)
                        {
                            Console.WriteLine("Palpite muito alto. Tente novamente.");
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número válido.");
                        Console.WriteLine("\n");
                    }

                } while (palpite != numeroAleatorio);

                Console.WriteLine("Fim do jogo. Obrigado por jogar!");

            }




            Console.ReadKey();
        }
    }
}
