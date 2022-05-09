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
                switch (itemGroup.Key)
                {
                    case "A":
                        while (itemCount >= 3)
                        {
                            itemCount -= 3;
                            total += 130;
                        }

                        total += itemCount * 50;
                        break;
                    case "B":
                        while (itemCount >= 2)
                        {
                            itemCount -= 2;
                            total += 45;
                        }

                        total += itemCount * 30;
                        break;
                    default:
                        total += _priceList[itemGroup.Key];
                        break;
                }
            }

            return total;
        }

    }
}