using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMVC.Controller;
using TesteMVC.Model;

namespace TesteMVC.View
{
    class ViewProduto
    {
        public static void Adicionar() 
        {
            //Solicitação da quantidade de produtos a serem adicionados
            Console.WriteLine("Quantos produtos deseja adicionar ?");
            int qtdProd = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < qtdProd; i++)
            {
                Console.WriteLine("Produto: {0}",i+1);
                Console.WriteLine("Digite o nome do produto");
                string nomeProd = Console.ReadLine() ?? "";

                Console.WriteLine("Digite a quantidade de produto: ");
                int qtd = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o preço do produto");
                double precoProd = Convert.ToDouble(Console.ReadLine());

                ControllerProduto.Adicionar(nomeProd, precoProd,qtd);
                Console.WriteLine("Produto adicionado com sucesso !");
            }
        }

        public static void AlterarProd() 
        {
            int op;
            do
            {
                Console.WriteLine("Qual opção deseja");
                Console.WriteLine("1 - Alterar quantidade de produto");
                Console.WriteLine("2 - Alterar produto específico");
                Console.WriteLine("3 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op) 
                {
                    case 1:
                        ControleEstoque.MostrarMenu();
                        break;
                    
                    case 2:
                        Alterar();
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }while (op != 3);
        }

        public static void Alterar() 
        {
            //Lista para receber os produtos
            List<ModelProduto> produtos = ControllerProduto.Listar();

            //Laço para exibir os produtos
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco} - {item.quantidade}");
            }
            Console.WriteLine();
            
            //Solicitação do índice do produto que deseja alterar
            Console.WriteLine("Digite o indice do produto que deseja alterar");
            int indiceProd = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do produto: ");
            string nomeAlt = Console.ReadLine() ?? "";

            Console.WriteLine("Digite o preço do produto: ");
            double precoAlt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de produto: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            ControllerProduto.Alterar(indiceProd,nomeAlt,precoAlt,qtd);
            Console.WriteLine("Produto alterado com sucesso !");
        }

        public static void Listar() 
        {
            //Lista para receber os produtos
            List<ModelProduto> produtos = ControllerProduto.Listar();

            //Laço para exibir os produtos
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco} - {item.quantidade}");
            }
            Console.WriteLine();
            
            //Exibe a quantidade de produtos
            Console.WriteLine("Número de produtos: {0}",produtos.Count);
        }

        public static void Deletar() 
        {
            //Lista para receber os produtos
            List<ModelProduto> produtos = ControllerProduto.Listar();
            
            //Laço para exibir os produtos
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco} - {item.quantidade}");
            }
            Console.WriteLine();

            //Solicitação do índice do produto que deseja deletar
            Console.WriteLine("Digite o índice do produto que deseja deletar: ");
            int indiceProd = Convert.ToInt32(Console.ReadLine());

            ControllerProduto.Deletar(indiceProd);
            Console.WriteLine("Produto deletado com sucesso !");
        }
    }
}
