
using System.Runtime.ConstrainedExecution;

Shop s = new Shop();
bool exit = false;
do
{
    PrintMenu();

    int choice = IntInput("Premi il numero per selezionare");

    switch (choice)
    {

        case 1:
            //Console.Clear();
            //s.AddProduct();
            //Console.Clear();
            break;


        case 2:
            //Console.Clear();
            //s.PrintProducts(s.GetProducts());

            break;

        case 3:
            //Product p = new Product();
            //p = s.GetItem(s.UserString("Digita il nome del prodotto da cercare"));
            //Console.Clear();
            //Console.WriteLine("Il prezzo ivato è " + p.VatPrice(p) + " Euro");
            break;

        default:
            exit = true;
            break;
    }

} while (!exit);


// utility

static void PrintMenu()
{
    Console.WriteLine("");
    Console.WriteLine("Azioni: ");
    Console.WriteLine("1.Aggiungi");
    Console.WriteLine("2.Visualizza");
    Console.WriteLine("3.Visualizza prezzo ivato di un prodotto");
    Console.WriteLine("5.Esci");
    Console.WriteLine("");

   
}

static int IntInput(string message)
{

    Chiedi:
    Console.WriteLine(message);
    string s = Console.ReadLine();
    if (s == null)
    {
        Console.WriteLine("inserimento non valido. Riprova");
        goto Chiedi;
    }


    return Convert.ToInt32(s);

}

static string StringInput(string message)
{
    Chiedi:
    Console.WriteLine(message);
    string s = Console.ReadLine();
    if (s == null)
    {
        Console.WriteLine("inserimento non valido. Riprova");
        goto Chiedi;
    }

    return s; 
}

static double DoubleInput(string message)
{
    Chiedi:
    Console.WriteLine(message);
    string s = Console.ReadLine();
    if (s == null)
    {
        Console.WriteLine("inserimento non valido. Riprova");
        goto Chiedi;
    }

    return Convert.ToDouble(s);


}


