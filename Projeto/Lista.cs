class Lista
{
    List<Person> lista = new List<Person>();

    public void Inserir()
    {
        Console.WriteLine("Insira o Index da pessoa:");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o Id da pessoa:");
        string id = Console.ReadLine();

        Console.WriteLine("Insira o FirstName da pessoa:");
        string firstname = Console.ReadLine();

        Console.WriteLine("Insira o LastName da pessoa:");
        string lastname = Console.ReadLine();

        Console.WriteLine("Insira o Sex da pessoa:");
        string sex = Console.ReadLine();

        Console.WriteLine("Insira o Email da pessoa:");
        string email = Console.ReadLine();

        Console.WriteLine("Insira o Phone da pessoa:");
        string phone = Console.ReadLine();

        Console.WriteLine("Insira o DateOfBirth da pessoa:");
        string dateofbirth = Console.ReadLine();

        Console.WriteLine("Insira o JobTitle da pessoa:");
        string jobtitle = Console.ReadLine();

        Person pessoa = new Person(index, id, firstname, lastname, sex, email, phone, dateofbirth, jobtitle);

        lista.Add(pessoa);
    }

    public void Remover()
    {
        Console.WriteLine("Insira o Index da pessoa a ser removida:");
        int index = int.Parse(Console.ReadLine());

        lista.RemoveAll(p => p.Index == index);
    }
    public void Listar()
    {
        foreach (var pessoa in lista)
        {
            Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");

            Console.WriteLine("--------------------------------------------------");
        }
    }

    public void BuscarPorIndex()
    {
        Console.WriteLine("Insira o Index da pessoa a ser buscada:");
        int index = int.Parse(Console.ReadLine());

        var pessoa = lista.FirstOrDefault(p => p.Index == index);

        if (pessoa != null)
        {
            Console.WriteLine($"Index: {pessoa.Index}, Id: {pessoa.Id}, FirstName: {pessoa.FirstName}, LastName: {pessoa.LastName}, Sex: {pessoa.Sex}, Email: {pessoa.Email}, Phone: {pessoa.Phone}, DateOfBirth: {pessoa.DateOfBirth}, JobTitle: {pessoa.JobTitle}");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
    }
}