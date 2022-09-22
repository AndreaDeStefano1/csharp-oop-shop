class Water : Product, IShop
{
    public double Liter { get; set; }
    public double Ph { get; set; }
    public string Source { get; set; }
    public Water(double liter, double ph, int code, string name, string description, double price, int maxQuantity, int quantityAvaible) : base(code, name, description, price, maxQuantity, quantityAvaible)
    {
        Vat = 4;
        Ph = ph;
        Liter = liter;
    }

    public int QuantityToOrder(int quantity)
    {
        return MaxQuantity - quantity;
    }

    public double VatPrice()
    {
        double vatPrice;

        vatPrice = (Price * Vat) / 100;

        return vatPrice + Price;
    }

    public override void Print()
    {
        Console.WriteLine($"Nome: {Name} \nDescrizione: {Description} \nPrice: {Math.Round(VatPrice())} \nDisponibilità: {QuantityAvaible} \nPh: {Ph} \nLitri: {Liter}\n\n");

    }
    public override void PrintList()
    {
        Console.WriteLine($"\nNome: {Name}  {Math.Round(VatPrice())}€");
    }
}
