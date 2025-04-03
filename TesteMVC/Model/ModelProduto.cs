using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMVC.Model
{
    class ModelProduto
    {
        //Declaração de variáveis
        public string nome;
        public double preco;
        public int quantidade;

        public ModelProduto() { }

        //Construtor para adição dos produtos
        public ModelProduto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;

            produtos.Add(this);
        }

        //Metodos Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //Metodos Get e Set
        public double Preco
        {
            get{ return preco; }
            
            set{
                if (preco > 0)
                {
                    preco = value;
                }
                else 
                {
                    Console.WriteLine("O valor não pode ser negativo");
                }
            }
        }

        //Lista para adição de produtos
        public static List<ModelProduto> produtos = new List<ModelProduto>();

        //Método para adicionar produtos
        public static void AdicionarProd(int indice, int qtd) 
        {
            produtos[indice].quantidade += qtd;
        }

        //Método para remover produtos
        public static void RemoverProd(int indice, int qtd) 
        {
            produtos[indice].quantidade -= qtd;
        }

        //Metodo para alteração
        public static void Alterar(int indice, string nome, double preco, int quantidade)
        {
            produtos[indice].Nome = nome;
            produtos[indice].Preco = preco;
            produtos[indice].quantidade = quantidade;
        }

        //Método para listar
        public static List<ModelProduto> Listar() 
        {
            return produtos;
        }

        //Método para deletar
        public static void Deletar(int indice) 
        {
            produtos.RemoveAt(indice);
        } 

    }
}
