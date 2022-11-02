// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
Prodotto Numero1 = new Prodotto();
Numero1.SetNome("libro");
Numero1.SetDescrizione("libro di informatica");
Numero1.SetPrezzo(17);
Numero1.SetIva(10);

Console.WriteLine(Numero1.GetCod());
Console.WriteLine(Numero1.GetNome());
Console.WriteLine(Numero1.GetDescrizione());
Console.WriteLine(Numero1.GetPrezzo());
Console.WriteLine(Numero1.GetIva());
Console.WriteLine(Numero1.PrezzoTot());
Console.WriteLine(Numero1.Nome());
Console.WriteLine(Numero1.Codice(Numero1.GetCod()));







public class Prodotto
{
    private int cod;
    private string nome;
    private string descrizione;
    private double prezzo;
    private int iva;


    public Prodotto()
    {
        cod = new Random().Next(1000, 9999);

    }

    public int GetCod()
    {
        return cod;
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetDescrizione()
    {
        return descrizione;
    }

    public double GetPrezzo()
    {
        return prezzo;
    }

    public int GetIva()
    {
        return iva;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }

    public void SetPrezzo(double prezzo)
    {
        this.prezzo = prezzo;
    }

    public void SetIva(int iva)
    {
        this.iva = iva;
    }

    public double PrezzoTot()
    {
        return prezzo + (prezzo / 100 * iva);
    }

    public string Nome()
    {
        return  cod + "nome:" + nome;
    }

    public string Codice(int cod)
    {
        string codice = Convert.ToString(cod);

        for (int i = 0; i <8; i++)
        {
          codice = "0" + codice;
        }

        return codice;

        
    }




















}