
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
Console.OutputEncoding = System.Text.Encoding.UTF8;



bool exit = false;
Shop s = new Shop();
// Inizializzo dei prodotti
#region 

Water w = new Water(1.5, 7, RandomCodeGenerator(), "Ferrarelle", "Fresca come l'acqua", 1.35,  100, 57);
s.products.Add(w);
Water w2 = new Water(2, 6.5, RandomCodeGenerator(), "Lete", "Fresca come la ferrarelle", 0.30,  100, 1);
s.products.Add(w2);

FruitBag f = new FruitBag(RandomCodeGenerator(), "Banana in pezzi", "Frutta fresca in pezzi", 1.5,  20, 2, 5);
s.products.Add(f);
FruitBag f2 = new FruitBag(RandomCodeGenerator(), "Macedonia in pezzi", "Frutta fresca in pezzi", 3.5,  10, 5, 5);
s.products.Add(f2);

Appliances a = new Appliances(RandomCodeGenerator(), "Frigorifero Whirpoll", "MOD. F43222", 100,  3, 1, "A", 2.5, 0.75);
s.products.Add(a);
Appliances a2 = new Appliances(RandomCodeGenerator(), "Frigorifero", "MOD. FX43222", 100.99, 3, 1, "A", 2.5, 0.75);
s.products.Add(a2);
#endregion 

do
{
    PrintMenu();

    int choice = IntInput("Premi il numero per selezionare");

    switch (choice)
    {

        case 1:
            foreach (Product item in s.products)
            {
                item.PrintList();
            }
            
            break;


        case 2:
            string prodotto = "0";
            do
            {
                prodotto = StringInput("Cosa vuoi aggiungere al carello? Premi 0 per uscire");
                s.AddProduct(prodotto);
            } while (prodotto != "0");
           

            break;

        case 3:
            Console.WriteLine(s.TotalPrice());
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
    Console.WriteLine("1.Stampa catalogo");
    Console.WriteLine("2.Aggiungi prodotto al carrello");
    Console.WriteLine("3.Visualizza prezzo ivato di un prodotto");
    Console.WriteLine("5.Esci");
    Console.WriteLine("");

   
}

static int IntInput(string message)
{

    Console.WriteLine(message);
    string s = Console.ReadLine();
    while (s == null)
    {
        Console.WriteLine("inserimento non valido. Riprova");
        s = Console.ReadLine();

    }


    return Convert.ToInt32(s);

}

static string StringInput(string message)
{
    Console.WriteLine(message);
    string s = Console.ReadLine();
    while (s == null)
    {
        Console.WriteLine("inserimento non valido. Riprova");
        s = Console.ReadLine();

    }

    return s; 
}

static double DoubleInput(string message)
{
    Console.WriteLine(message);
    string s = Console.ReadLine();
    while (s == null)
    {
        Console.WriteLine("inserimento non valido. Riprova");
        s = Console.ReadLine();

    }

    return Convert.ToDouble(s);


}

static int RandomCodeGenerator()
{
       

    int code;

    Random r = new Random();
    code = r.Next(1, 99999999);

    return code;

}

