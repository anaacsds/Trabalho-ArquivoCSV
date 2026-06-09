using System.IO;
using System.Collections.Generic;

namespace LeitorDados
{
    class Leitor_Dados
    {
        // Alteração: O método agora recebe o 'limiteRegistros' que controlará o loop FOR
        public void carregarDados(string caminhoArquivo, List<Person> listaDoGrupo, int limiteRegistros)
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("Arquivo não encontrado!");
                    return;
                }

                using (StreamReader leitor = new StreamReader(caminhoArquivo))
                {
                    leitor.ReadLine(); // Pula a primeira linha (cabeçalho)


                    for (int i = 0; i < limiteRegistros; i++) // Loop controlado pelo 'limiteRegistros' passado como parâmetro de acordo com usuario
                    {
                        string linha = leitor.ReadLine();

                        if (linha == null) break;

                        string[] dados = linha.Split(',');

                        // Remove as aspas e converte os dados para os tipos corretos
                        int Index = int.Parse(dados[0].Replace("\"", ""));
                        string Id = dados[1].Replace("\"", "");
                        string FirstName = dados[2].Replace("\"", "");
                        string LastName = dados[3].Replace("\"", "");
                        string Sex = dados[4].Replace("\"", "");
                        string Email = dados[5].Replace("\"", "");
                        string Phone = dados[6].Replace("\"", "");
                        string DateOfBirth = dados[7].Replace("\"", "");
                        string JobTitle = dados[8].Replace("\"", "");

                        // Cria o objeto completo com os dados da linha
                        Person novoRegistro = new Person(Index, Id, FirstName, LastName, Sex, Email, Phone, DateOfBirth, JobTitle);

                        // Insere o objeto na lista
                        listaDoGrupo.Add(novoRegistro);
                    }
                }
                Console.WriteLine($"\n--> Sucesso: {limiteRegistros} registros foram salvos na TAD! <--");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
            }
        }
    }
}
