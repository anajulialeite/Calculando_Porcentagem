using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace aprendendoC_
{
    class Program
    {
        static void Main(string[] args)
        {

            //criando objeto da classe livre
            Livro livro1 = new Livro
            {
                titulo = "Prince: A Private View",
                autor = "Afshin Shahidi",
                anoDePublicacao = 2017,
                preco = 500.00m
            };

            //chamando o método mostrarDetalhes
            livro1.mostrarDetalhes();

            //chamando o método aplicarDesconto para aplicar um desconto de 5%
            livro1.AplicarDesconto(5);

            //mostrando o detalhe do livro após o desconto
            Console.WriteLine("\nApós aplicar o desconto");
            livro1.mostrarDetalhes();

        }
    }
}