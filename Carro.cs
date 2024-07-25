using System;


public class veiculo
{
    private string marca;
    private string modelo;
    private int ano;


    public void MostrarDetalhes()
    {
        Console.WriteLine("Marca" + marca);
        Console.WriteLine("Modelo" + modelo);
        Console.WriteLine("ano" + ano);

    }

    public string Getmarca()
    {
        return marca;
    }


    public void Setmarca(string novamarca)
    {
        marca = novamarca;
    }

    public string Getmodelo()
    {
        return modelo;
    }


    public void Setmodelo(string novomodelo)
    {
        modelo = novomodelo;
    }

    public int Getano()
    {
        return ano;
    }


    public void Setano(int novoano)
    {
        ano = novoano;
    }




}

public class carro : veiculo
{
    public void ligar()
    {
        Console.WriteLine("Carro Ligado");
    }
}

class program
{
    public static void Main(string[] args)
    {
        carro meucarro = new carro();
        meucarro.Setmarca("toyota") ;
        meucarro.Setmodelo("corolla");
        meucarro.Setano(1992);
        meucarro.MostrarDetalhes();
        meucarro.ligar();
    }
}
