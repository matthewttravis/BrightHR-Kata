using NUnit.Framework;

namespace ShoppingCartKata
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void CanScanItemA()
        {
            var checkout = new Checkout();
            checkout.Scan("A");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(total, 50);
        }
        
        [Test]
        public void CanScanItemB()
        {
            var checkout = new Checkout();
            checkout.Scan("B");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(total, 30);
        }

        [Test]
        public void CanScanItemC()
        {
            var checkout = new Checkout();
            checkout.Scan("C");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(total, 20);
        }

        [Test]
        public void CanScanItemD()
        {
            var checkout = new Checkout();
            checkout.Scan("D");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(total, 15);
        }
    }
}