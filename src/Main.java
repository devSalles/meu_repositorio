import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        //Variável condição while
        boolean running=true;

        while (running)
        {
            //Switch para escolher onde será adicionado o funcionário
            System.out.println("-------------------------------------------------------");
            System.out.println("Digite qual setor você deseja adicionar o funcionário: ");
            System.out.println("1.Assistente Administrativo");
            System.out.println("2.Assistente Técnico");
            System.out.println("3.Assistente Geral");
            System.out.println("4.Gerente");
            System.out.println("5.Sair do sistema");
            System.out.println("Digite o número para selecionar: ");
            int op=sc.nextInt();
            System.out.println("-------------------------------------------------------");
            switch (op)
            {
                case 1:
                    Funcionario administrativo = new Administrativo();
                    administrativo.cadastro();
                break;

                case 2:
                    Funcionario tecnico = new Tecnico();
                    tecnico.cadastro();
                break;

                case 3:
                    Funcionario assistencia = new Assistentes();
                    assistencia.cadastro();
                break;

                case 4:
                    Funcionario gerente = new Gerente();
                    gerente.cadastro();
                break;

                case 5:
                    System.out.println("Saindo do sistema");
                    running=false;
                break;

                default:
                    System.out.println("Algo de errado foi digitado");
                    running=false;
                break;
            }
        }
    }
}