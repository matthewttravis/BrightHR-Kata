﻿namespace ShoppingCartKata
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
                case "B":
                    _total += 30;
                    return;
                case "C":
                    _total += 20;
                    return;
                case "D":
                    _total += 15;
                    return;
            }
        }

        public int GetTotalPrice()
        {
            return _total;
        }
    }
}