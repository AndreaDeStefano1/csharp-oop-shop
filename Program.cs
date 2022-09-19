// Aggiungi prodotto 
// rimuovi Prodotto
Shop s = new Shop();
bool exit = false;
do
{
    
    Console.WriteLine("Azioni: ");
    Console.WriteLine("1.Aggiungi");
    Console.WriteLine("2.Visualizza");
    Console.WriteLine("5.Esci");
    Console.WriteLine("");

    Console.WriteLine("Premi il numero per selezionare ");



    switch (Convert.ToInt32(Console.ReadLine()))
    {

        case 1:
            s.AddProduct();
            Console.Clear();
            break;

        case 2:
            s.PrintProducts(s.GetProducts());
            break;

        default:
            exit = true;
            break;
    }

} while (!exit);

