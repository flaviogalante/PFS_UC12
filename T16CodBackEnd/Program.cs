// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using T16CodBackEnd.Classes;

// metodo construtor
PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Adriano";
novaPf.cpf = 1112223345;
novaPf.dataNasc = new DateTime(2001, 01, 01);
novaPf.endereco = "Rua Niteroi, 180";
novaPf.rendimento = 12000;

Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine("CPF: " + novaPf.cpf);
Console.WriteLine("Data de Nascimento: " + novaPf.dataNasc);
Console.WriteLine("Endereço: " + novaPf.endereco);
Console.WriteLine("Rendimento: R$ " + novaPf.rendimento + ",00");

//Concatenação
//Console.WriteLine("Nome do Funcionário: " + novaPf.nome);

//Interpolação
Console.WriteLine($"Nome do Funcionário: {novaPf.nome} - CPF: {novaPf.cpf}");