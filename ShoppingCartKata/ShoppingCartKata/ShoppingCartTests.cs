using NUnit.Framework;

namespace ShoppingCartKata
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void CanScanItem()
        {
            var checkout = new Checkout();
            checkout.Scan("A");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(total, 50);
        }
    }
}