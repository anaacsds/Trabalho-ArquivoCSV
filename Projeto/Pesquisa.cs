/* Implemente uma funcionalidade de pesquisa, onde o usuário poderá escolher um atributo da classe e
informar um valor para buscar todos os registros correspondentes. Essa busca deverá ser binária, com
os registros ordenados pelo método sort da lista

A pesquisa deve percorrer a lista e exibir os resultados encontrados. */

class Pesquisa
{
    public void Pesquisar(List<Person> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("Lista vazia.");
            return;
        }

        Console.WriteLine("\nPesquisar por qual atributo?");
        Console.WriteLine("1. Index");
        Console.WriteLine("2. ID");
        Console.WriteLine("3. Primeiro Nome");
        Console.WriteLine("4. Sobrenome");
        Console.WriteLine("5. Sexo");
        Console.WriteLine("6. Email");
        Console.WriteLine("7. Telefone");
        Console.WriteLine("8. Data de Nascimento");
        Console.WriteLine("9. Cargo");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor a buscar: ");
        string valor = Console.ReadLine();

        List<Person> resultados;
        int idx, esq, dir;

        switch (opcao)
        {
            case 1:
                int indexValor = int.Parse(valor);

                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.Index.CompareTo(b.Index));

                idx = resultados.BinarySearch(
                    new Person(indexValor, "", "", "", "", "", "", "", ""),
                    Comparer<Person>.Create((a, b) => a.Index.CompareTo(b.Index))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                    break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].Index == indexValor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].Index == indexValor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }


                break;

            case 2:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.Id.CompareTo(b.Id));

                idx = resultados.BinarySearch(
                    new Person(0, valor, "", "", "", "", "", "", ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.Id, b.Id))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].Id == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].Id == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 3:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));

                idx = resultados.BinarySearch(
                    new Person(0, "", valor, "", "", "", "", "", ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.FirstName, b.FirstName))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].FirstName == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].FirstName == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 4:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.LastName.CompareTo(b.LastName));

                idx = resultados.BinarySearch(
                    new Person(0, "", "", valor, "", "", "", "", ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.LastName, b.LastName))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].LastName == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].LastName == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 5:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.Sex.CompareTo(b.Sex));

                idx = resultados.BinarySearch(
                    new Person(0, "", "", "", valor, "", "", "", ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.Sex, b.Sex))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].Sex == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].Sex == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 6:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.Email.CompareTo(b.Email));

                idx = resultados.BinarySearch(
                    new Person(0, "", "", "", "", valor, "", "", ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.Email, b.Email))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].Email == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].Email == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 7:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.Phone.CompareTo(b.Phone));

                idx = resultados.BinarySearch(
                    new Person(0, "", "", "", "", "", valor, "", ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.Phone, b.Phone))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].Phone == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].Phone == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 8:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.DateOfBirth.CompareTo(b.DateOfBirth));

                idx = resultados.BinarySearch(
                    new Person(0, "", "", "", "", "", "", valor, ""),
                    Comparer<Person>.Create((a, b) => string.Compare(a.DateOfBirth, b.DateOfBirth))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].DateOfBirth == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].DateOfBirth == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            case 9:
                resultados = new List<Person>(lista);
                resultados.Sort((a, b) => a.JobTitle.CompareTo(b.JobTitle));

                idx = resultados.BinarySearch(
                    new Person(0, "", "", "", "", "", "", "", valor),
                    Comparer<Person>.Create((a, b) => string.Compare(a.JobTitle, b.JobTitle))
                );

                if (idx < 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado."); break;
                }

                esq = idx; dir = idx;
                while (esq > 0 && resultados[esq - 1].JobTitle == valor)
                {
                    esq--;
                }
                while (dir < resultados.Count - 1 && resultados[dir + 1].JobTitle == valor)
                {
                    dir++;
                }

                for (int i = esq; i <= dir; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Index: {resultados[i].Index}, Id: {resultados[i].Id}, FirstName: {resultados[i].FirstName}, LastName: {resultados[i].LastName}, Sex: {resultados[i].Sex}, Email: {resultados[i].Email}, Phone: {resultados[i].Phone}, DateOfBirth: {resultados[i].DateOfBirth}, JobTitle: {resultados[i].JobTitle}");

                    Console.WriteLine("--------------------------------------------------");
                }

                break;

            default:
                Console.WriteLine("Opcao inválida.");
                break;
        }
    }
}