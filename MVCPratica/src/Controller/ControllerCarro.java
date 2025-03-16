package Controller;
import Model.ModelCarro;
import java.util.List;

public class ControllerCarro {
    public static void Cadastrar(String montadora, String modelo, double preco)
    {
        if(preco<0)
        {
            System.out.println("Valor negativo digitado");
            System.exit(0);
        }
        else
        {
            new ModelCarro(montadora, modelo, preco);
        }
    }

    public static List<ModelCarro> Listar()
    {
        //Verificação de itens na lista
        if (ModelCarro.Carros.stream().count()==0)
        {
            System.out.println("A lista está vazia");
        }

        return ModelCarro.Carros;
    }

    public static void Excluir(int indice)
    {
        for (ModelCarro modelCarro : ModelCarro.Carros)
        {
            System.out.println(modelCarro.Montadora + " - " + modelCarro.Modelo + " - " + modelCarro.Preco);
        }
        System.out.println();

        //Verificação de índice
        if(indice>=0 && indice< ModelCarro.Carros.stream().count())
        {
            ModelCarro.Excluir(indice);
        }
        else
        {
            System.out.println("índice inexistente");
            System.exit(0);
        }
    }

    public static void Alterar(int indice, String modelo, String montadora, double preco)
    {
        for (ModelCarro modelCarro : ModelCarro.Carros)
        {
            System.out.println(modelCarro.Montadora + " - " + modelCarro.Modelo + " - " + modelCarro.Preco);
        }
        System.out.println();

        //Verificação de índice
        if(indice>=0 && indice<ModelCarro.Carros.stream().count())
        {
            ModelCarro.Alterar(indice, modelo, montadora, preco);
        }
        else
        {
            System.out.println("índice inexistente");
            System.exit(0);
        }
    }
}
