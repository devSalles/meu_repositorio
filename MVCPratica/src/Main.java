import View.ViewCarro;

public class Main {
    public static void main(String[] args) {
        int op=0;
        do{
            System.out.println("1-Cadastrar Carro");
            System.out.println("2-Listar Carros");
            System.out.println("3-Excluir Carro");
            System.out.println("4-Alterar Carro");
            System.out.println("5-Sair");
            System.out.println("Escolha a opção desejada");
            op=Integer.parseInt(System.console().readLine());
            switch (op){
                case 1:
                    ViewCarro.Cadastrar();
                    break;
                case 2:
                    ViewCarro.Listar();
                    break;
                case 3:
                    ViewCarro.Excluir();
                    break;
                case 4:
                    ViewCarro.Alterar();
                    break;
                case 5:
                    System.out.println("Saindo do sistema");
                    break;
                default:
                    System.out.println("Opção inválida");
                    break;
            }
        }while (op!=5);
    }
}