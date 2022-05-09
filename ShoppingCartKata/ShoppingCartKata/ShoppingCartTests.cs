using NUnit.Framework;

namespace ShoppingCartKata
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [TestCaseSource(typeof(TestItemData), nameof(TestItemData.Items))]
        public int CanScanItems(List<string> items)
        {
            var checkout = new Checkout();
            
            foreach (var item in items)
            {
                checkout.Scan(item);
            }
            
            return checkout.GetTotalPrice();
        }
    }
}