using TesteMVC.View;

namespace TesteMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Váriavel de controle do menu e do loop Do While
            int op = 0;

            do
            {
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Alterar Produto");
                Console.WriteLine("3. Listar Produto");
                Console.WriteLine("4. Deletar Produto");
                Console.WriteLine("5. Sair");
                Console.WriteLine("Qual opção deseja: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        ViewProduto.Adicionar();
                        break;
                    
                    case 2:
                        Console.Clear();
                        ViewProduto.AlterarProd();
                        break;
                    
                    case 3:
                        Console.Clear();
                        ViewProduto.Listar();
                        break;
                    
                    case 4:
                        Console.Clear();
                        ViewProduto.Deletar();
                        break;
                    
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }
            while (op!=5);
        }
    }
}
