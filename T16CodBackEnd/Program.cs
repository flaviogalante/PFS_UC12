// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using T16CodBackEnd.Classes;

// metodo construtor
PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica();

//novaPf.nome = "Adriano";
//novaPf.cpf = 1112223345;
//novaPf.dataNasc = new DateTime(2001, 01, 01);
//novaPf.endereco = "Rua Niteroi, 180";
//novaPf.rendimento = 10000.00f;

//novaPj.rendimento = 20000.00f;

//Console.WriteLine("Nome: " + novaPf.nome);
//Console.WriteLine("CPF: " + novaPf.cpf);
//Console.WriteLine("Data de Nascimento: " + novaPf.dataNasc);
//Console.WriteLine("Endereço: " + novaPf.endereco);
//Console.WriteLine("Rendimento: R$ " + novaPf.rendimento + ",00");

//Concatenação
//Console.WriteLine("Nome do Funcionário: " + novaPf.nome);

//Interpolação
//Console.WriteLine($"Nome do Funcionário: {novaPf.nome} - CPF: {novaPf.cpf}");

//Console.WriteLine(novaPf.CalcularImposto(novaPf.rendimento));
//Console.WriteLine(novaPj.CalcularImposto(novaPj.rendimento));

//float impostoPagar = novaPj.CalcularImposto(10000.5f);
//Console.WriteLine($"O imposto a pagar será de: {impostoPagar.ToString("C")}");


// Encontro-Remoto-4

DateTime datNascimento = new DateTime(1984,10,19);

DateTime date1 = DateTime.Now;
DateTime date2 = DateTime.UtcNow;
DateTime date3 = DateTime.Today;

var dataResult = date3 - datNascimento;

var idade = dataResult.TotalDays/365;


Console.WriteLine(date1);
Console.WriteLine(date2);
Console.WriteLine(date3);

Console.WriteLine(novaPf.ValidarDataNasc(datNascimento));
Console.WriteLine(novaPf.ValidarDataNasc("19-10-1984"));

// Fim do Encontro-Remoto-4
