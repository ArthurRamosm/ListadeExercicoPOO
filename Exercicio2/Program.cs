using Exercicio2;


ContaBancaria contabancaria = new ContaBancaria();


Console.WriteLine("Digite o numero da conta:");
contabancaria.NumeroConta = Console.ReadLine();

Console.WriteLine("Digite o nome do titular:");
contabancaria.Titular = Console.ReadLine();

Console.WriteLine("Digite 1 para Verificar o saldo.");
Console.WriteLine("Digite 2 para depositar.");
Console.WriteLine("Digite 3 para sacar. ");
Console.WriteLine("Digite 4 para Sair. ");

int opcao = int.Parse(Console.ReadLine());

do
{

    if (opcao == 1)
    {
        Console.WriteLine($"Seu saldo atual é:{contabancaria.Saldo}");
        Console.WriteLine("Digite outra opção:");
        opcao = int.Parse(Console.ReadLine());
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Digite o valor que deseja depositar:");
        double ValorDepositar = double.Parse(Console.ReadLine());
        contabancaria.Depositar(ValorDepositar);
        Console.WriteLine("Digite outra opção:");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Digite o valor que deseja Sacar:");
        double ValorSacar = double.Parse(Console.ReadLine());
        contabancaria.Sacar(ValorSacar);
        Console.WriteLine("Digite outra opção:");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    else if (opcao == 4)
        Console.WriteLine("Obrigado pela preferência");
    else
    {

        Console.WriteLine("Opção Invalida, Tente Novamente");
        Console.WriteLine("Digite outra opção:");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();
    }
}
while (opcao != 4);

    




















