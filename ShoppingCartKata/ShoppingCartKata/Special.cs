namespace ShoppingCartKata;

public class Special
{
    public string Sku {get; set;}
    public int Count {get; set;}
    public int Price {get; set;}

    public Special(string sku, int count, int price)
    {
        Sku = sku;
        Count = count;
        Price = price;
    }
}