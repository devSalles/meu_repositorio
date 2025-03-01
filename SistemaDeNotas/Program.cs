namespace SistemaDeNotas
{
    //Classe para armazenar os atributos dos alunos
    public class Aluno 
    {
        public int Id;
        public string Name;
        public double Nota1, Nota2, Nota3, Nota4;
    }
    class Program
    {
        //Instância da classe aluno
        public static Aluno aluno = new Aluno();
       
        //Lista para adicionar os alunos 
        public static List<Aluno> Estudantes = new List<Aluno>();

        //HashSet para impedir a repetição de ID
        public static HashSet<int> IdAlunos = new HashSet<int>();

        //Metodo para adicionar aluno
        public static void AddAluno() 
        {

            Console.WriteLine("Quantos alunos você adicionar: ");
            if (!int.TryParse(Console.ReadLine(), out int qtd)) 
            {
                Console.WriteLine("Digite apenas números");
                return;
            }

            //Loop FOR para repetir a quantidade de aluno para ser adicionado a lista
            for (int i = 0; i < qtd; i++)
            {

                Console.WriteLine("{0}° Aluno", i+1);
                
                Console.WriteLine("Digite o ID do aluno: ");
                if (!int.TryParse(Console.ReadLine(), out int id)) 
                {
                    Console.WriteLine("Digite apenas números inteiros");
                    i--;
                }

                //IF para verificar a existencia de ID repitido 
                if (!IdAlunos.Add(id)) 
                {
                    Console.WriteLine("ID repetido inválido");
                    return;
                }
                
                aluno.Id = id;

                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine().ToLower();

                //Criar um objeto aluno para ser adicionado a lista 
                Estudantes.Add(new Aluno { Id = id, Name = nome });

            }
        }

        //Metodo para remover aluno
        public static void RemoverAluno() 
        {

            Console.WriteLine("Digite o ID do aluno que deseja remover");
            if (!int.TryParse(Console.ReadLine(), out int IdRemover)) 
            {
                Console.WriteLine("Digite apenas números inteiros");
            }
           
            //IF para remover o aluno
            if (IdRemover.Equals(aluno.Id)) 
            {
                Estudantes.Remove(aluno);
            }
        }

        //Metodo para verificar situação 
        public static void VerificarSituacao() 
        {

            Console.WriteLine("Digite o ID do aluno que deseja verificar as notas");
            if (!int.TryParse(Console.ReadLine(), out int VerificarNota)) 
            {
                Console.WriteLine("Digite apenas números inteiros");
            }
            if (VerificarNota.Equals(aluno.Id))
            {
                Console.WriteLine("Digite 1° a nota do aluno: ");
                double nota1=double.Parse(Console.ReadLine());
                aluno.Nota1 = nota1;
                
                //IF para verificar a nota do aluno
                if (nota1>25) 
                {
                    Console.WriteLine("A médio máxima e 25");
                }
                

                Console.WriteLine("Digite a 2° nota do aluno: ");
                double nota2 = double.Parse(Console.ReadLine());
                aluno.Nota2 = nota2;

                //IF para verificar a nota do aluno
                if (nota2 > 25)
                {
                    Console.WriteLine("A médio máxima e 25");
                }

                Console.WriteLine("Digite a 3° nota do aluno: ");
                double nota3 = double.Parse(Console.ReadLine());
                aluno.Nota3 = nota3;

                //IF para verificar a nota do aluno
                if (nota3 > 25)
                {
                    Console.WriteLine("A médio máxima e 25");
                }

                Console.WriteLine("Digite a 4° nota do aluno: ");
                double nota4 = double.Parse(Console.ReadLine());
                aluno.Nota4 = nota4;

                //IF para verificar a nota do aluno
                if (nota4 > 25)
                {
                    Console.WriteLine("A médio máxima e 25");
                }

                //Fazer o calculo da média
                double media=aluno.Nota1+aluno.Nota2+aluno.Nota3+aluno.Nota4;

                //Aninhamento de IF para verificar a situação do aluno
                if (media >= 60 && media <=100)
                {
                    Console.WriteLine("Aluno aprovado");
                    Console.WriteLine("Nota final: {0}",media);
                }
                else if (media >= 45 && media < 60)
                {
                    Console.WriteLine("Aluno em recuperação");
                    Console.WriteLine("Nota final: {0}", media);

                }
                else 
                {
                    Console.WriteLine("O aluno foi reprovado");
                    Console.WriteLine("Nota final: {0}", media);
                }

            }
        }

        //Metodo para listagem dos alunos
        public static void ListasAlunos() 
        {
            //Lista vazia
            if (Estudantes.Count == 0) 
            {
                Console.WriteLine("Nenhum aluno na lista");
            }

            //Leitura da lista
            foreach (var item in Estudantes)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }
        static void Main(string[] args)
        {
            //Variável de condição while
            bool running = true;

            while (running) 
            {
                inicio:
                Console.WriteLine("1.Adicionar aluno");
                Console.WriteLine("2.Remover aluno");
                Console.WriteLine("3.Verificar notas de um aluno");
                Console.WriteLine("4.Listas alunos");
                Console.WriteLine("5.Sair do sistema");
                if (!int.TryParse(Console.ReadLine(), out int op)) 
                {
                    Console.WriteLine("Digite apenas números inteiros");
                }
                switch (op) 
                {
                    case 1:
                        Console.Clear();
                        AddAluno();
                    break;

                    case 2:
                        Console.Clear();
                        RemoverAluno();
                    break;
                    
                    case 3:
                        Console.Clear();
                        VerificarSituacao();
                    break;

                    case 4:
                        Console.Clear();
                        ListasAlunos();
                    break;

                    case 5:
                        Console.Clear();
                        running = false;
                        Console.WriteLine("Saindo do sistema");
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Digite apenas entre 1 e 4");
                    goto inicio;
                    
                }
            }
        }
    }
}
