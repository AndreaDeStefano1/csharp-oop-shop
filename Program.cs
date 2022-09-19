// Aggiungi prodotto 
// rimuovi Prodotto
Shop s = new Shop();
bool exit = false;
do
{
    Console.WriteLine("");
    Console.WriteLine("Azioni: ");
    Console.WriteLine("1.Aggiungi");
    Console.WriteLine("2.Visualizza");
    Console.WriteLine("3.Visualizza prezzo ivato di un prodotto");
    Console.WriteLine("5.Esci");
    Console.WriteLine("");

    Console.WriteLine("Premi il numero per selezionare ");



    switch (Convert.ToInt32(Console.ReadLine()))
    {

        case 1:
            Console.Clear();
            s.AddProduct();
            Console.Clear();
            break;


        case 2:
            Console.Clear();
            s.PrintProducts(s.GetProducts());

            break;

        case 3:
            Product p = new Product();
            p = s.GetItem(s.UserString("Digita il nome del prodotto da cercare"));
            Console.Clear();
            Console.WriteLine("Il prezzo ivato è " + p.VatPrice(p) + " Euro");
            break;

        default:
            exit = true;
            break;
    }

} while (!exit);

