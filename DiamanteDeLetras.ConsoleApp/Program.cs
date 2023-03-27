using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static int linhaIncial = 1;
        static int letraEmInt = 65;
        static int tamanhoFinal;
        static bool eNumero;
        static void Main(string[] args)
        {
            const string SAIR = "S";
            string respostaSAIR = "";
            while (respostaSAIR.ToUpper() != SAIR)
            {
                Menu();
                if (eNumero){
                    MensagemDeErro("variavel nao é número...");
                    continue;
                }
                EscreveDiamantePraCima();              
                EscreveDiamantePrabaixo();
                ResetaValor();
                Console.WriteLine("Sair S/N");
                respostaSAIR = Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void EscreveDiamantePrabaixo()
        {
            for (int i = 0; linhaIncial > 0; i++)
            {

                for (int j = 1; j <= tamanhoFinal; j++)
                {

                    Console.Write(" ");
                }

                for (int j = 1; j <= linhaIncial; j++)
                {
                    if (j == 1 || j == linhaIncial)
                    {
                        Console.Write(Convert.ToChar(letraEmInt));
                    }
                    Console.Write(" ");

                }

                tamanhoFinal++;
                linhaIncial -= 2;
                letraEmInt -= 1;
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        private static void EscreveDiamantePraCima()
        {
            for (int i = 1; tamanhoFinal > 0; i++)
            {

                for (int j = 1; j <= tamanhoFinal; j++)
                {
  
                    Console.Write(" ");

                }

                for (int j = 1; j <= linhaIncial; j++)
                {
                    if (j == 1 || j == linhaIncial)
                    {
                        Console.Write(Convert.ToChar(letraEmInt));
                    }
                    Console.Write(" ");

                }

                tamanhoFinal--;
                linhaIncial += 2;
                letraEmInt += 1;
                Console.WriteLine("");
                Console.WriteLine("");

            }
        }

         static void MensagemDeErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = ConsoleColor.White;
        }

         static void Menu()
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine("Até Qual Letra vai o Diamante: ");
            char tamanhoEmChar = Convert.ToChar(Console.ReadLine().ToUpper());
            tamanhoFinal = Convert.ToInt32(tamanhoEmChar) - 65;
            string charParaString = Convert.ToString(tamanhoEmChar);
            eNumero = charParaString.All(char.IsDigit);
        }
        static void ResetaValor()
        {
             linhaIncial = 1;
             letraEmInt = 65;
        }
    }
}