using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void AdicionarEstoque(int quantidade)
        {
           Quantidade += quantidade;


        }
        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public void ExibirDetalhes() 
        {
            Console.WriteLine(Nome + ", $ " + Preco + ", " + Quantidade + " unidades");
        }
        

    }
}
