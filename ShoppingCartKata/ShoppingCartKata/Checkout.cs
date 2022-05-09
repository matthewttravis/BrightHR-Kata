namespace ShoppingCartKata
{
    public class Checkout: ICheckout
    {
        private int _total;

        public void Scan(string item)
        {
            switch (item)
            {
                case "A":
                    _total += 50;
                    return;
            }
        }

        public int GetTotalPrice()
        {
            return _total;
        }
    }
}