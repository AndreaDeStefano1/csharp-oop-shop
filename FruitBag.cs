class FruitBag : Product, IShop
{
    public int PiecePerBag { get; set; }

    public FruitBag(int code, string name, string description, double price, int maxQuantity, int quantityAvaible, int piecePerBag) : base(code, name, description, price, maxQuantity, quantityAvaible)
    {
        Vat = 4;
        PiecePerBag = piecePerBag;
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
        Console.WriteLine($"Nome: {Name} \nDescrizione: {Description} \nPrice: {VatPrice()} \nDisponibilità: {QuantityAvaible} \nPezzi in confezione: {PiecePerBag} \n\n");

    }
    public override void PrintList()
    {
        Console.WriteLine($"\nNome: {Name}  {Math.Round(VatPrice())}€");
    }
}