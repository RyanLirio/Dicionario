//Diferente da tabela hash o Dictionary nos permite
//expecificar o tipo de dado que será utilizado nos pares 
//key -> value
//isso nos fornece uma estrutura fortemente tipada

using System.ComponentModel;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using Dicionario;
echo "# Dicionario" >> README.md
Dictionary<string, string> dictionary = new Dictionary<string, string>()

{
    {"Chave 1", "Valor 1"},
    {"Chave 2", "Valor 2"},
};

//Obter valor do dictionary
string val = dictionary["Chave 1"];

try
{
    val = dictionary["chave 3"];
}
catch(Exception ex)
{
    Console.WriteLine("Erro ao obter valor de chave 3");
    Console.WriteLine(ex.Message);
}
//Verificando se a chave existe de acessar
//para evitar erros e prejuizos de execução

if(dictionary.ContainsKey("Chave 2")){
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

//Outra forma de obter o valor e evitar erri
dictionary.TryGetValue("Chave 4", out string? valor);
if(val is not null)
    Console.WriteLine($"Chave 4: {val}");

//Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "Valor 0";

//Percorrer o dicionario
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}
// utilizando tipos abstratos de dados com dicionario

Dictionary<int, Pessoa > dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add
(
    1,
    new Pessoa(){
        Id = 0,
        BirthDate = new DateTime(2005, 11, 4),
        Name = "Ryan Lirio"
    }
);
foreach( KeyValuePair<int, Pessoa>kvp in dicPessoa)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}