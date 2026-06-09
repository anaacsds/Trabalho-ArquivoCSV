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
        Console.Write("Opcao: ");
        int opcao = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor a buscar: ");
        string valor = Console.ReadLine();

        List<Person> resultados = new List<Person>();

        resultados = lista;

        switch (opcao)
        {
            case 1:
                int indexValor = int.Parse(valor);

                resultados.OrderBy(p => p.Index).ToList();
                resultados = resultados.Where(p => p.Index == indexValor).ToList();

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
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:

                break;
            case 7:

                break;
            case 8:
                break;
            case 9:
                break;
            default:
                Console.WriteLine("Opcao inválida.");
                break;
        }
    }
}