class Water : Product
{
    public double Liter { get; set; }
    public double Ph { get; set; }
    public string Source { get; set; }
    public Water(double liter, double ph, int code, string name, string description, double price, int vat, int maxQuantity, int quantityAvaible) : base(code, name, description, price, vat, maxQuantity, quantityAvaible)
    {
        Ph = ph;
        Liter = liter;
    }


}
