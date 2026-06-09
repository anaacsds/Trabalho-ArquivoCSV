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

        List<Person> resultados = new List<Person>();

        resultados = lista;

        switch (opcao)
        {
            case 1:
                int IndexValor = int.Parse(valor);

                resultados.OrderBy(p => p.Index).ToList();
                resultados = resultados.Where(p => p.Index == IndexValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 2:
                string IdValor = valor;
                resultados.OrderBy(p => p.Id).ToList();
                resultados = resultados.Where(p => p.Id == IdValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 3:
                string FirstNameValor = valor;
                resultados.OrderBy(p => p.FirstName).ToList();
                resultados = resultados.Where(p => p.FirstName == FirstNameValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }


                break;
            case 4:
                string LastNameValor = valor;
                resultados.OrderBy(p => p.LastName).ToList();
                resultados = resultados.Where(p => p.LastName == LastNameValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 5:
                string SexValor = valor;
                resultados.OrderBy(p => p.Sex).ToList();
                resultados = resultados.Where(p => p.Sex == SexValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 6:
                string EmailValor = valor;
                resultados.OrderBy(p => p.Email).ToList();
                resultados = resultados.Where(p => p.Email == EmailValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 7:
                string PhoneValor = valor;
                resultados.OrderBy(p => p.Phone).ToList();
                resultados = resultados.Where(p => p.Phone == PhoneValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 8:
                string DateOfBirthValor = valor;
                resultados.OrderBy(p => p.DateOfBirth).ToList();
                resultados = resultados.Where(p => p.DateOfBirth == DateOfBirthValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            case 9:
                string JobTitleValor = valor;
                resultados.OrderBy(p => p.JobTitle).ToList();
                resultados = resultados.Where(p => p.JobTitle == JobTitleValor).ToList();

                if (resultados.Count == 0)
                {
                    Console.WriteLine("Nenhum resultado encontrado.");
                }
                else
                {
                    foreach (var pessoa in resultados)
                    {
                        Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
                    }
                }
                break;
            default:
                Console.WriteLine("Opcao inválida.");
                break;
        }
    }
}
