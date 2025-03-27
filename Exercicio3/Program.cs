
using System.Globalization;
using Exercicio3;


Console.WriteLine("Digite o numero de produtos que deseja adicionar:");
int QuantProduto = int.Parse(Console.ReadLine());

Produto[] vetor = new Produto[QuantProduto];

for (int i = 0; i < QuantProduto; i++)
{
    Console.WriteLine("Digite o nome do produto:");
    string Nome = Console.ReadLine();
    Console.WriteLine("Digite o Preço do produto:");
    double Preco = double.Parse(Console.ReadLine());

    Produto _produto = new Produto { Nome = Nome, Preco = Preco };
    Console.WriteLine("Digite a quantidade de produtos a ser adicionadas:");
    _produto.Quantidade = int.Parse(Console.ReadLine());

    Console.WriteLine();
    vetor[i] = _produto;
}
Console.Clear();

for (int i = 0; i < QuantProduto; i++)
{
    vetor[i].ExibirDetalhes();
}
bool ContinuarRemover = true;

while (ContinuarRemover)
{

    Console.WriteLine("Deseja modificar algum produto?(s/n)");
    char Modificar = char.Parse(Console.ReadLine().ToUpper());

    if (Modificar == 'S')
    {
        Console.WriteLine("Digite o nome do produto: ");
        string NomeProd = Console.ReadLine().ToUpper();
        bool ProdutoEncontrado = false;

        for (int i = 0; i < QuantProduto; i++)
        {

            if (vetor[i].Nome == NomeProd)
            {
                Console.Write("Digite a quantidade a ser removido do estoque: ");
                vetor[i].RemoverEstoque(int.Parse(Console.ReadLine()));
                Console.Clear();

                Console.WriteLine($"Dados atualizados: ");
                for (int x = 0; x < QuantProduto; x++)
                {
                    vetor[x].ExibirDetalhes();
                }
            }

        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Dados atualizados: ");
        for (int i = 0; i < QuantProduto; i++)
        {

            vetor[i].ExibirDetalhes();
            ContinuarRemover = false;
        }
    }
}







