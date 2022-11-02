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


public class Prodotto
{
    private int cod;
    private string nome;
    private string descrizione;
    private float prezzo;
    private int iva;


    public Prodotto(string nome, string descrizione, float prezzo, int iva )
    {
        cod = new Random().Next(1000, 9999);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        this.iva = iva;

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

    public float GetPrezzo()
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

    public void SetPrezzo(float prezzo)
    {
        this.prezzo = prezzo;
    }

    public void SetIva(int iva)
    {
        this.iva = iva;
    }

    public float PrezzoTot()
    {
        return prezzo + iva;
    }

    public void Nome()
    {
        Console.WriteLine("cod:" + cod + "nome" + nome);
    }




















}