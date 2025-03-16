package View;
import Controller.ControllerCarro;
import Model.ModelCarro;
import java.util.List;
import java.util.Scanner;

public class ViewCarro {
    public static void Cadastrar()
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Quantos carros deseja cadastrar : ");
        int qtd=sc.nextInt();

        for (int i = 0; i < qtd ; i++) {
            System.out.println("Carro " + (i+1) + "");

            System.out.println("Digite a marca do carro");
            String carBrand = sc.nextLine();
            sc.nextLine();

            System.out.println("Digite o modelo do carro");
            String carModel = sc.nextLine();

            System.out.println("Digite o preco do carro");
            double carPrice = sc.nextDouble();

            ControllerCarro.Cadastrar(carBrand,carModel,carPrice);
        }

    }

    public static void Listar()
    {
        List<ModelCarro> carro = ControllerCarro.Listar();

        for (ModelCarro modelCarro : carro)
        {
            System.out.println(modelCarro.Montadora + " - " + modelCarro.Modelo + " - " + modelCarro.Preco);
        }
    }

    public static void Excluir()
    {
        Scanner sc = new Scanner(System.in);
        List<ModelCarro> carroExcluir = ControllerCarro.Listar();

        for (ModelCarro carro:carroExcluir)
        {
            System.out.println(carro.Montadora+ "-" +carro.Modelo+ "-" + carro.Preco);
        }

        System.out.println("Digite o índice para excluir o carro");
        int indice=sc.nextInt();

        ControllerCarro.Excluir(indice);
    }

    public static void Alterar()
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Digite o indice do carro que deseja alterar");
        int indice=sc.nextInt();
        System.out.println("Digite o novo modelo");
        String novoModelo = sc.nextLine();
        sc.nextLine();

        System.out.println("Digite a nova marca");
        String novaMontadora = sc.nextLine();

        System.out.println("Digite o novo preco");
        double novoPreco = sc.nextDouble();

        ControllerCarro.Alterar(indice,novoModelo,novaMontadora,novoPreco);

    }
}
