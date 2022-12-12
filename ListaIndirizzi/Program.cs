// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Indirizzo> listaIndirizzi = new List<Indirizzo>;

try
{
    //Apro canale di lettura con il file
    StreamReader file = File.OpenText("addresses.csv");





    StreamReader file = File.OpenText("\"C:\\Users\\ALESSANDRA\\Desktop\\Esercizi .NET\\ListaIndirizzi\\addresses.csv\"");





    //Controllo che il file non sia finito
    while (!file.EndOfStream)
    {
        //Leggo il contenuto
        string addressLine = file.ReadLine();

        string[] informazioniIndirizzo = addressLine.Split(" , ");

        string nome = informazioniIndirizzo[0];
        string cognome = informazioniIndirizzo[1];
        string via = informazioniIndirizzo[2];
        string città = informazioniIndirizzo[3];
        string provincia = informazioniIndirizzo[4];
        string codicepostale = informazioniIndirizzo[5];

        Indirizzo indirizzoEstratto = new Indirizzo(nome, cognome, via, città, provincia, codicepostale);
        listaIndirizzi.Add(indirizzoEstratto);
        Console.WriteLine(addressLine);
    }

    file.Close();
}

catch (FileNotFoundException e)
{
    Console.WriteLine("File not found");


    foreach (Indirizzo indirizzo in listaIndirizzi)
    {
        Console.WriteLine(indirizzo);
    }

}
