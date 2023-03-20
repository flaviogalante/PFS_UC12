// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using T16CodBackEnd.Classes;

// metodo construtor
//PessoaFisica novaPf = new PessoaFisica();
//Endereco novoEndPf = new Endereco();
// 

//novaPf.nome = "Flavio";
//novaPf.cpf = 1112223345;
//novaPf.dataNasc = new DateTime(1984, 10, 19);
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

// DateTime datNascimento = new DateTime(1984,10,19);

// DateTime date1 = DateTime.Now;
// DateTime date2 = DateTime.UtcNow;
// DateTime date3 = DateTime.Today;

// var dataResult = date3 - datNascimento;

// var idade = dataResult.TotalDays/365;


// Console.WriteLine(date1);
// Console.WriteLine(date2);
// Console.WriteLine(date3);

// Console.WriteLine(novaPf.ValidarDataNasc(datNascimento));
// Console.WriteLine(novaPf.ValidarDataNasc("19-10-1984"));

// Fim do Encontro-Remoto-4

// Encontro-Remoto-5

// PESSOA JURÍDICA

//PessoaJuridica novaPj = new PessoaJuridica();
//Endereco novoEndPj = new Endereco();

 //Console.WriteLine(novaPj.ValidarCnpj("27379542000173"));
 //Console.WriteLine(novaPj.ValidarCnpj("31.876.411/0001-79"));



//novaPj.razaoSocial = "Flavio Machado - ME";
//novaPj.cnpj = "31.876.411/0001-79";
//novaPj.rendimento = 200000.00f;

//novoEndPj.logradouro = "Rua Copacabana";
//novoEndPj.numero = 354;
//novoEndPj.complemento = "Empresa de Informática";
//novoEndPj.endComercial = true;

//novaPj.endereco = novoEndPj;

//Console.WriteLine(@$"

//Nome da Razão Social: {novaPj.razaoSocial}
//Endereço: {novoEndPj.logradouro}, {novoEndPj.numero}
//CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)} 
//");

// Fim do Encontro-Remoto-5

//Encontro-Remoto 6

string? opcao;

Console.ForegroundColor = ConsoleColor.DarkRed;
Utils.BarraCarregamento("Inicializando");

Console.Clear();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine(@$"
--------------------------------------------------------------
|        Seja Bem Vindo ao Nosso Sistema de Cadastro de      |
|                  Pessoas Físicas e Jurídicas               |
--------------------------------------------------------------
");

// Dormir/Sleep = 1 segundo / 1000 = 1 milisegundo
Thread.Sleep(2000);
Console.Clear();

do
{
Console.WriteLine(@$"
--------------------------------------------------------------
|                Escolha uma opção abaixo:                    |
|                   1 - Pessoa Física                         |
|                   2 - Pessoa Jurídica                       |
|                   0 - Sair do Sistema                       |
--------------------------------------------------------------
");

Console.ResetColor();


Console.WriteLine($"Digite uma das opções acima e tecle 'Enter' !");
opcao = Console.ReadLine();
// Console.WriteLine($" O texto digitado foi: {opcao}");

switch (opcao)
{
    case "1":
        Console.WriteLine($"Pessoa Física Selecionada");

// Pessoa Física
//Método construtor

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPf = new Endereco();


            novaPF.nome = "Flavio Machado";
            novaPF.cpf = 123456789;
            novaPF.dataNasc = new DateTime(1984, 10, 19);

            novaPF.rendimento = 10000;

            novoEndPf.logradouro = "Rua Niteroi";
            novoEndPf.numero = 180;
            novoEndPf.complemento = "Senai Informática";
            novoEndPf.endComercial = true;

            novaPF.endereco = novoEndPf;

            Console.WriteLine(@$"
            Nome: {novaPF.nome}
            CPF: {novaPF.cpf}
            Data de nascimento: {novaPF.dataNasc}
            Endereço: {novoEndPf.logradouro} , {novoEndPf.numero} , {novoEndPf.complemento} , {novoEndPf.endComercial}
            Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
            ");

        Console.WriteLine($"Tecle 'Enter' para continuar!");
        Console.ReadLine();  
        break;

    case "2":
        Console.WriteLine($"Pessoa Jurídica Selecionada"); 

// Pessoa Jurídica
// Método Construtor

        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();


        novaPj.razaoSocial = "Flavio Machado - ME";
        novaPj.cnpj = "31.876.411/0001-79";
        novaPj.rendimento = 200000.00f;

        novoEndPj.logradouro = "Rua Copacabana";
        novoEndPj.numero = 354;
        novoEndPj.complemento = "Empresa de Informática";
        novoEndPj.endComercial = true;

        Console.WriteLine(@$"

        Nome da Razão Social: {novaPj.razaoSocial}
        Endereço: {novoEndPj.logradouro}, {novoEndPj.numero}
        CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)} 
        ");

        Console.WriteLine($"Tecle 'Enter' para continuar!");
        Console.ReadLine();  
        break;

    case "0":
        Console.WriteLine($"Saindo do Sistema");
        break;

    default:
        Console.WriteLine($"Opção não encontrada. Digite uma das opções acima");
        break;
}


Thread.Sleep(2000);
Console.Clear();

} while (opcao != "0");

Utils.BarraCarregamento("Finalizando");

// Fim do Encontro-Remoto-6
