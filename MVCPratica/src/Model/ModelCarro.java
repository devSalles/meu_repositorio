package Model;

import java.util.ArrayList;
import java.util.List;

public class ModelCarro {
    public String Montadora;
    public String Modelo;
    public double Preco;

    public static List<ModelCarro> Carros = new ArrayList<>();

    public ModelCarro(String montadora, String modelo, double preco) {
        Montadora = montadora;
        Modelo = modelo;
        Preco = preco;

        ModelCarro.Carros.add(this);
    }

    public static void Excluir(int indice)
    {
        ModelCarro.Carros.remove(indice);
    }

    public static void Alterar(int indice, String modelo, String montadora, double preco)
    {
        ModelCarro.Carros.get(indice).Modelo=modelo;
        ModelCarro.Carros.get(indice).Montadora=montadora;
        ModelCarro.Carros.get(indice).Preco=preco;
    }

}
