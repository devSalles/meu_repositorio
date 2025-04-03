using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMVC.Controller;
using TesteMVC.Model;

namespace TesteMVC.View
{
    class ControleEstoque
    {

        public static void MostrarMenu()
        {
            //Varável de controle para o menu e loop Do while
            int opcao;
            do
            {
                Console.WriteLine("1. Adicionar produto");
                Console.WriteLine("2. Remover produto");
                Console.WriteLine("3. Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        AdicionarProduto();
                        break;

                    case 2:
                        Console.Clear();
                        RemoverProduto();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 3);
        }

        private static void AdicionarProduto()
        {
            //Lista para receber 
            List<ModelProduto> productsList= ControllerProduto.Listar();
            //Loop para a exibição
            foreach (var product in productsList)
            {
                Console.WriteLine($"{product.nome} - R${product.preco} - {product.quantidade}");
            }
            Console.WriteLine();

            //Solicitação da quantidade de produtos a serem adicionados
            Console.WriteLine("Quantos produtos deseja adiconar: ");
            int qtdProd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qtdProd; i++)
            {
                Console.WriteLine("Digite o indice do produto que deseja adicionar");
                int.TryParse(Console.ReadLine(), out int index);

                Console.WriteLine("Digite a quantidade a ser adicionada");
                int.TryParse(Console.ReadLine(), out int qtd);

                ControllerProduto.AdicionarProd(index, qtd);

                Console.WriteLine("Quantidade adicionado");
                Console.WriteLine();

                //Exibir lista atualizada
                foreach (var product in productsList)
                {
                    Console.WriteLine($"{product.nome} - R${product.preco} - {product.quantidade}");
                }
            }
        }

        private static void RemoverProduto()
        {
            //Lista para receber
            List<ModelProduto> productList= ControllerProduto.Listar();
            //Loop para a exibição
            foreach (var product in productList)
            {
                Console.WriteLine($"{product.nome} - R${product.preco} - {product.quantidade}");
            }
            Console.WriteLine();

            //Solicitação da quantidade de produtos a serem adicionados
            Console.WriteLine("Quantos produtos deseja adiconar: ");
            int qtdProd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < qtdProd; i++)
            {
                Console.WriteLine("Digite o indice do produto que deseja remover");
                int.TryParse(Console.ReadLine(), out int index);

                Console.WriteLine("Digite a quantidade a ser removida");
                int.TryParse(Console.ReadLine(), out int qtd);

                ControllerProduto.RemoverProd(index, qtd);

                Console.WriteLine("Quantidade removido");
                Console.WriteLine();

                //Exibir lista atualizada
                foreach (var product in productList)
                {
                    Console.WriteLine($"{product.nome} - R${product.preco} - {product.quantidade}");
                }
            }
        }
    }
}
