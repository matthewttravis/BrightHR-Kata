namespace ShoppingCartKata
{
    public class Checkout: ICheckout
    {
        private int _total;

        private readonly Dictionary<string, int> _priceList;

        public Checkout()
        {
            _priceList = new Dictionary<string, int>
            {
                { "A", 50 },
                { "B", 30 },
                { "C", 20 },
                { "D", 15 }
            };
        }

        public void Scan(string item)
        {
            _total += _priceList[item];
        }

        public int GetTotalPrice()
        {
            return _total;
        }
    }
}