class Product
{
    int code;
    string name;
    string description;
    double price;
    int VAT;

    // COSTRUTTORI

    public Product()
    {

    }
    public Product(int code, string name, string description, double price, int vat)
    {
        this.code = code;
        this.name = name;
        this.description = description;
        this.price = price;
        this.VAT = vat;
    }

    public Product(string name, string description, double price, int vat)
    {
        this.code = RandomCodeGenerator();
        this.name = name;
        this.description = description;
        this.price = price;
        this.VAT = vat;
    }

    // GETTERS
    public int GetCode()
    {
        return this.code;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public double GetPrice()
    {
        return this.price;
    }

    public int GetVat()
    {
        return this.VAT;
    }

    // SETTERS

    private void SetCode(int code)
    {
        this.code = code; 
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void SetVat(int vat)
    {
        this.VAT = vat; 
    }

    // UTILITA'

    public int RandomCodeGenerator()
    {
        int code;

        Random r = new Random();
        code = r.Next(1, 99999999);

        return code;
    }

    public double VatPrice(Product p)
    {
        double vatPrice;

        vatPrice = (p.GetPrice() * p.GetVat()) / 100;

        return vatPrice + p.GetPrice();
    }

    public string NameWithCode(Product p)
    {
        string extendedName = "";
        return  extendedName = p.GetCode() + " - " + p.GetName();
    }
}