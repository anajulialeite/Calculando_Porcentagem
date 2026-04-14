using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoC_
{
    class Livro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anoDePublicacao { get; set; }
        public decimal preco { get; set; }


        public void mostrarDetalhes()
        {
            // Formatação do preço com 2 casas decimais
            Console.WriteLine($"título: {titulo}");
            Console.WriteLine($"autor: {autor}");
            Console.WriteLine($"ano de publicação: {anoDePublicacao}");
            Console.WriteLine($"preco: {preco.ToString("F2")}");
        }

        public void AplicarDesconto(decimal desconto)
        {
            preco -= preco * (desconto / 100); //aplica o desconto
        }
    }
}