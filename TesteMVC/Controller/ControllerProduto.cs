using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMVC.Model;

namespace TesteMVC.Controller
{
    class ControllerProduto
    {
        public static void Adicionar(string nome, double preco, int quantidade) 
        {
            //Verificação de números negativo
            if(preco < 0)
            {
                Console.WriteLine("O preço não pode ser negativo");
                return;
            }

            if(quantidade < 0)
            {
                Console.WriteLine("A quantidade não pode ser negativa");
                return;
            }
            
            //Verificação de nome nulo
            if (nome == null)
            {
                Console.WriteLine("O nome não pode ser nulo");
                return;
            }
            new ModelProduto(nome,preco, quantidade);
        }

        public static void AdicionarProd(int index, int quantidade) 
        {
            //Uso do TryCatch para verificar se o índice passado é válido
            try
            {
                ModelProduto.AdicionarProd(index, quantidade);
            }
            catch (ArgumentOutOfRangeException argument)
            {
                Console.WriteLine("Erro indíce inválido {0}", argument);
            }
        }
        public static void RemoverProd(int index, int quantidade) 
        {
            //Uso do TryCatch para verificar se o índice passado é válido
            try
            {
                ModelProduto.RemoverProd(index, quantidade);
            }
            catch (ArgumentOutOfRangeException argument)
            {
                Console.WriteLine("Erro indíce inválido {0}", argument);
            }
        }

        public static void Alterar(int indice, string nome, double preco, int quantidade) 
        {
            //Verifica de números negativo
            if (preco < 0) {
                Console.WriteLine("O preço não pode ser negativo");
                return;
            }

            if (quantidade < 0)
            {
                Console.WriteLine("A quantidade não pode ser negativa");
                return;
            }

            //Verifica se o nome é nulo
            if (nome == null) {
                Console.WriteLine("O nome não pode ser nulo");
                return;
            }

            //Verifica se o indice passado é válido
            if (indice >= 0 && indice < ModelProduto.produtos.Count)
            {
                ModelProduto.Alterar(indice, nome, preco, quantidade);
            }
            else 
            {
                Console.WriteLine("índice inválido");
            }
        }

        public static List<ModelProduto> Listar() 
        {
            //Verifica se a lista está vazia e exibe uma mensagem
            if (Model.ModelProduto.produtos.Count==0)
            {
                Console.WriteLine("Lista vazia");
            }
            //Exibe a lista de produtos
            return ModelProduto.Listar();
        }

        public static void Deletar(int indice) 
        {
            //Verifica se o indice passado é válido
            if (indice>=0 && indice < ModelProduto.produtos.Count) 
            {
                ModelProduto.Deletar(indice);
            }
            else
            {
                Console.WriteLine("índice inválido");
            }
        }
    }
}
