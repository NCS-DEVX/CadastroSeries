using System;
using System.Collections.Generic;

namespace CadastroDeNomeDeSerie
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<string> nomesDeSeries = new List<string>();


            int opcao = 0;
            do
            {
     
                Console.WriteLine("**Menu**");
                Console.WriteLine("1. Adicionar nome de série");
                Console.WriteLine("2. Remover nome de série");
                Console.WriteLine("3. Listar nomes de série");
                Console.WriteLine("0. Sair");

                // Le a opção do usuário
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Adiciona um nome de série
                        nomesDeSeries.Add(Console.ReadLine());
                        break;
                    case 2:
                        // Remove um nome de série
                        Console.WriteLine("Informe o nome da série que deseja remover:");
                        string nomeDeSerieParaRemover = Console.ReadLine();
                        nomesDeSeries.Remove(nomeDeSerieParaRemover);
                        break;
                    case 3:
                        // Lista os nomes de série
                        Console.WriteLine("**Nomes de série**");
                        foreach (string nomeDeSerie in nomesDeSeries)
                        {
                            Console.WriteLine(nomeDeSerie);
                        }
                        break;
                }
            } while (opcao != 0);
        }
    }
}
