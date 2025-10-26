using System;
using GerenciadorSenhaSingleton.Model;

namespace GerenciadorSenhaSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorSenha gerenciador = GerenciadorSenha.Instance;
            string opcao;

            do
            {
                Console.WriteLine("\n===== GERENCIADOR DE SENHAS =====");
                Console.WriteLine("1 - Gerar nova senha");
                Console.WriteLine("2 - Chamar próxima senha");
                Console.WriteLine("3 - Mostrar todas as senhas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        int novaSenha = gerenciador.GetNovaSenha();
                        Console.WriteLine($"Senha gerada: {novaSenha}");
                        break;

                    case "2":
                        gerenciador.ChamarProximaSenha();
                        break;

                    case "3":
                        List<int> lista = gerenciador.GetListaSenhas();
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("Nenhuma senha pendente.");
                        }
                        else
                        {
                            Console.WriteLine("Senhas pendentes:");
                            foreach (int s in lista)
                            {
                                Console.WriteLine($"- {s}");
                            }
                        }
                        break;

                    case "0":
                        Console.WriteLine("Encerrando...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != "0");
        }
    }
}
