

class Shop{
    Product[] products = new Product[100];

    public Product[] GetProducts()
    {
        return products;
    }
    public Product GetItem(string name)
    {
        Product p = new Product();
        foreach (Product item in products)
        {
            if (item.GetName() == name)
            {
                p = item;
                break;
            }
               
        }
        return p;
    }

    public string UserString(string message)
    {
        Console.WriteLine(message); 
        string input = Console.ReadLine();
        return input;
    }

    public double UserDouble(string message)
    {
        Console.WriteLine(message);
        double input = Convert.ToDouble(Console.ReadLine());
        return input;
            


    }
    public void AddProduct()
    {
        Product p = new Product(UserString("Inserisci il nome del prodotto"), UserString("Inserisci la descrizione"), UserDouble("Inserisci il prezzo"), 22);
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] == null)
            {
                products[i] = p;
                break;
            }
        }
    }

    public void PrintProducts(Product[] products)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] != null)
            {
                Console.WriteLine ((i + 1) +">>");
                Console.WriteLine("Nome: " + products[i].GetName());
                Console.WriteLine("Codice: " + products[i].GetCode());
                Console.WriteLine("Descrizione: " + products[i].GetDescription());
                Console.WriteLine("Prezzo: " + products[i].GetPrice());
                Console.WriteLine("Nome Completo: " + products[i].NameWithCode(products[i]));
                Console.WriteLine("--------");
                Console.WriteLine();
            }
        }
        if (products[0] == null )
        {
            //controllo stupido per vedere se l array è vuoto
            Console.WriteLine("Nessun prodotto");
        }
    }
}

