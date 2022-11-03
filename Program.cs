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


Console.WriteLine(Numero1.Cod);
Console.WriteLine(Numero1.Nome);
Console.WriteLine(Numero1.Descrizione);
Console.WriteLine(Numero1.Prezzo);
Console.WriteLine(Numero1.Iva);
Console.WriteLine(Numero1.PrezzoTot());
Console.WriteLine(Numero1.NomeEsteso());
Console.WriteLine(Numero1.Codice(Numero1.Cod));







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

    public int Cod
    {
        get { return cod; }
    }

    public string Nome
    {
        get { return nome; }
        set { this.nome = value; }
        
    }

    public string Descrizione
    {
        get { return descrizione; }
        set { this.descrizione = value; }
    }

    public double Prezzo
    {
        get { return prezzo; }
        set { this.prezzo = value; }
    }

    public int Iva
    {
        get { return iva; }
        set { this.iva = value; }
    }


    public double PrezzoTot()
    {
        return prezzo + (prezzo / 100 * iva);
    }

    public string NomeEsteso()
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