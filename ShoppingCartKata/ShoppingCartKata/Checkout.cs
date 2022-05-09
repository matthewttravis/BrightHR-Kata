namespace ShoppingCartKata
{
    public class Checkout: ICheckout
    {
        private readonly Dictionary<string, int> _priceList;
        private readonly List<Special> _specials;
        private readonly List<string> _shoppingCart = new List<string>();

        public Checkout()
        {
            _priceList = new Dictionary<string, int>
            {
                { "A", 50 },
                { "B", 30 },
                { "C", 20 },
                { "D", 15 }
            };

            _specials = new List<Special>
            {
                new Special("A", 3, 130),
                new Special("B", 2, 45)
            };
        }

        public void Scan(string item)
        {
            _shoppingCart.Add(item);
        }

        public int GetTotalPrice()
        {
            var total = 0;

            var groups = _shoppingCart.GroupBy(x => x);

            foreach (var itemGroup in groups)
            {
                total += ProcessPrice(itemGroup);
            }

            return total;
        }

        private int ProcessPrice(IGrouping<string, string> itemGroup)
        {
            var total = 0;
            var count = itemGroup.Count();

            var rule = _specials.SingleOrDefault(x => x.Sku == itemGroup.Key);

            if (rule != null)
            {
                while (count >= rule.Count)
                {
                    count -= rule.Count;
                    total += rule.Price;
                }
            }
            
            total += _priceList[itemGroup.Key] * count;

            return total;
        }
    }
}