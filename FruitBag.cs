class FruitBag : Product, IShop
{
    public int PiecePerBag { get; set; }

    public FruitBag(int code, string name, string description, double price, int vat, int maxQuantity, int quantityAvaible, int piecePerBag) : base(code, name, description, price, vat, maxQuantity, quantityAvaible)
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
}