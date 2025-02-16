import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Assistentes extends Funcionario {

    @Override
    public void cadastro() {

        //Listas para armazenar as informações
        List<String> Names=new ArrayList<String>();
        List<String> Cargos=new ArrayList<String>();
        List<Integer> Matricula = new ArrayList<Integer>();
        List<Integer> Salarios = new ArrayList<Integer>();

        Scanner sc=new Scanner(System.in);

        //Variável condição while
        boolean running=true;

        while (running) {
            System.out.println("Digite o nome do funcionário: ");
            String nome = sc.nextLine();
            Names.add(nome);

            System.out.println("Digite o cargo do funcionário: ");
            String funcao = sc.nextLine();
            Cargos.add(funcao);

            System.out.println("Digite o número de matrícula do funcionário: ");
            int matricula = sc.nextInt();
            Matricula.add(matricula);

            System.out.println("Digite o salário do funcionário: ");
            int sal = sc.nextInt();
            Salarios.add(sal);

            //Estrurtura para exibição de nomes
            for (int i = 0; i < Names.size(); i++) {
                System.out.println("------------------------------------");
                System.out.println("Nome do funcionário: " + Names.get(i));
                System.out.println("Cargo do funcionário: " + Cargos.get(i));
                System.out.println("Número de matrícula: " + Matricula.get(i));
                System.out.println("Salário do funcionário: " + Salarios.get(i));
                System.out.println("------------------------------------");
            }

            //Condição para parada do programa
            System.out.println("Deseja adicionar outro funcionário (1 para adicionar outro funcionário e 0 para sair)? ");
            int opcao = sc.nextInt();
            sc.nextLine();
            if (opcao==0) {
                System.out.println("Saindo do sistema!");
                running = false;
            }
       }
    }
}
