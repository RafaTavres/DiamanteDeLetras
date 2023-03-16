using System;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SAIR = "S";
            string respostaSAIR = "";

            while (respostaSAIR.ToUpper() != SAIR)
            {
                int linhaIncial = 1;
                int letraEmInt = 65;
                Console.WriteLine("\n------------------");

                Console.WriteLine("Até Qual Letra vai o Diamante: ");
                char tamanhoEmChar = Convert.ToChar(Console.ReadLine().ToUpper());
                int tamanhoFinal = Convert.ToInt32(tamanhoEmChar) - 65;
                string charParaString = Convert.ToString(tamanhoEmChar);
                bool eNumero = charParaString.All(char.IsDigit);

                if (eNumero)
                {
                    Console.WriteLine("Erro: O valor deve ser letra...");
                    continue;
                }

                #region Pra Cima
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
                #endregion

                #region Pra Baixo
                for (int i = 1; linhaIncial > 0; i++)
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
                #endregion

                Console.WriteLine("Sair S/N");
                respostaSAIR = Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}