using System;
using System.Collections.Generic;
using LeitorDados;

class Program
{
    static void Main()
    {
        List<Person> lista = new List<Person>();
        Leitor_Dados leitor = new Leitor_Dados();

        Console.WriteLine("Quantos registros deseja carregar?");
        Console.WriteLine("1. 100 registros");
        Console.WriteLine("2. 1000 registros");
        Console.WriteLine("3. 10000 registros");
        Console.WriteLine("4. 100000 registros");

        int registros = int.Parse(Console.ReadLine());

        while (registros < 1 || registros > 4)
        {
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 4.");
            registros = int.Parse(Console.ReadLine());
        }
        switch (registros)
        {
            case 1:
                registros = 100;
                break;
            case 2:
                registros = 1000;
                break;
            case 3:
                registros = 10000;
                break;
            case 4:
                registros = 100000;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        string caminhoArquivo = "";

        switch (registros)
        {
            case 100:
                caminhoArquivo = @"csv\people-100.csv";
                break;
            case 1000:
                caminhoArquivo = @"csv\people-1000.csv";
                break;
            case 10000:
                caminhoArquivo = @"csv\people-10000.csv";
                break;
            case 100000:
                caminhoArquivo = @"csv\people-100000.csv";
                break;
        }

        leitor.carregarDados(caminhoArquivo, lista, registros);

        Lista listaOperacoes = new Lista(lista);
        Pesquisa pesquisaOperacoes = new Pesquisa();

        while (true)
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Inserir");
            Console.WriteLine("2. Remover");
            Console.WriteLine("3. Listar");
            Console.WriteLine("4. Buscar por Index");
            Console.WriteLine("5. Pesquisar");
            Console.WriteLine("6. Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    listaOperacoes.Inserir();
                    break;
                case 2:
                    listaOperacoes.Remover();
                    break;
                case 3:
                    listaOperacoes.Listar();
                    break;
                case 4:
                    listaOperacoes.BuscarPorIndex();
                    break;
                case 5:
                    pesquisaOperacoes.Pesquisar(lista);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}