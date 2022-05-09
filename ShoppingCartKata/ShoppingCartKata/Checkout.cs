namespace ShoppingCartKata
{
    public class Checkout: ICheckout
    {
        private readonly Dictionary<string, int> _priceList;
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
                var itemCount = itemGroup.Count();
                if (itemGroup.Key == "A")
                {
                    while (itemCount >= 3)
                    {
                        itemCount -= 3;
                        total += 130;
                    }

                    total += itemCount * 50;
                }
                else
                {
                    total += _priceList[itemGroup.Key];
                }
            }

            return total;
        }

    }
}