import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

public class Administrativo extends Funcionario{
    @Override
    public void cadastro() {

        //Listas para armazenar as informações
        List<String> Names=new ArrayList<String>();
        List<String> Cargos=new ArrayList<String>();
        List<Integer> Salarios = new ArrayList<Integer>();
        List<String> Turno= new ArrayList<String>();
        List<Integer> Adicional=new ArrayList<Integer>();

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

            System.out.println("Digite o salário do funcionário: ");
            int sal = sc.nextInt();
            Salarios.add(sal);

            System.out.println("Digite o turno: ");
            String turno = sc.nextLine();
            Turno.add(turno);
            sc.nextLine();

            System.out.println("Digite o adicional: ");
            int ad = sc.nextInt();
            Adicional.add(ad);
            sc.nextLine();

            //Estrurtura para exibição de nomes
            for (int i = 0; i < Names.size(); i++) {
                System.out.println("------------------------------------");
                System.out.println("Nome do funcionário: " + Names.get(i));
                System.out.println("Cargo do funcionário: " + Cargos.get(i));
                System.out.println("Salário do funcionário: " + Salarios.get(i));
                System.out.println("Turno: " + Turno.get(i));
                System.out.println("Adicional: " + Adicional.get(i));
                System.out.println("Salário total: " + (Salarios.get(i) + Adicional.get(i)));
                System.out.println("------------------------------------");
            }

            //Condição para parada do programa
            System.out.println("Deseja adicionar outro funcionário ? (1 para adicionar outro funcionário e 0 para sair) ");
            int opcao = sc.nextInt();
            sc.nextLine();
            if (opcao==0) {
                System.out.println("Saindo do sistema!");
                running = false;
            }
        }
    }
}
