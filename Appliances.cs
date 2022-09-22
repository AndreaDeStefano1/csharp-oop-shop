/// vecchia versione

#region
//class Product
//{
//    int code;
//    string codeWithPad;
//    string name;
//    string description;
//    double price;
//    int VAT;

//    // COSTRUTTORI

//    public Product()
//    {

//    }


//    public Product(string name, string description, double price, int vat)
//    {
//        this.code = RandomCodeGenerator();
//        this.codeWithPad = PaddedCode(this.code);
//        this.name = name;
//        this.description = description;
//        this.price = price;
//        this.VAT = vat;
//    }

//    // GETTERS
//    public int GetCode()
//    {
//        return this.code;
//    }
//    public string GetPaddedCode()
//    {
//        return this.codeWithPad;
//    }

//    public string GetName()
//    {
//        return this.name;
//    }

//    public string GetDescription()
//    {
//        return this.description;
//    }

//    public double GetPrice()
//    {
//        return this.price;
//    }

//    public int GetVat()
//    {
//        return this.VAT;
//    }

//    // SETTERS

//    private void SetCode(int code)
//    {
//        this.code = code; 
//    }

//    public void SetName(string name)
//    {
//        this.name = name;
//    }

//    public void SetDescription(string description)
//    {
//        this.description = description;
//    }

//    public void SetPrice(double price)
//    {
//        this.price = price;
//    }

//    public void SetVat(int vat)
//    {
//        this.VAT = vat; 
//    }

//    // UTILITA'

//    public int RandomCodeGenerator()
//    {
//        int code;

//        Random r = new Random();
//        code = r.Next(1, 99999999);

//        return code;
//    }


//    public string PaddedCode( int code)
//    {
//        string stringCode = code.ToString();
//        while (stringCode.Length < 8)
//        {
//            stringCode = "0" + stringCode;
//        }
//        return stringCode;
//    }

//    public double VatPrice(Product p)
//    {
//        double vatPrice;

//        vatPrice = (p.GetPrice() * p.GetVat()) / 100;

//        return vatPrice + p.GetPrice();
//    }

//    public string NameWithCode(Product p)
//    {
//        string extendedName = "";
//        return  extendedName = p.GetCode() + " - " + p.GetName();
//    }

//    public abstract double GetWheight();
//    public abstract int GetQuantity();


//}

#endregion

// nuova versione

class Appliances : Product, IShop
{

    public string EnergyRating { get; set; }
    public double Heigth { get; set; }
    public double Width { get; set; }

    public Appliances(int code, string name, string description, double price, int maxQuantity, int quantityAvaible, string energyRating, double heigth, double width) : base(code, name, description, price, maxQuantity, quantityAvaible)
    {
        Vat = 22;
        EnergyRating = energyRating;
        Heigth = heigth;
        Width = width;
    }

    public double VatPrice()
    {
        double vatPrice;

        vatPrice = (Price * Vat) / 100;
        vatPrice = vatPrice + Price;


        return vatPrice;
    }

    public int QuantityToOrder(int quantity)
    {
        return MaxQuantity - quantity;
    }
    public override void Print()
    {
        Console.WriteLine($"Nome: {Name} \nDescrizione: {Description} \nPrice: {VatPrice()} \nDisponibilità: {QuantityAvaible} \nClasse energetica: {EnergyRating} \nDimensioni: altezza {Heigth}cm, larghezza {Width}cm");

    }

    public override void PrintList()
    {
        Console.WriteLine($"\nNome: {Name}  {Math.Round(VatPrice())}€");
    }



}