using NUnit.Framework;

namespace ShoppingCartKata
{
    [TestFixture]
    public class ShoppingCartTests
    {
        #region Single Item Tests

        [Test]
        public void CanScanItemA()
        {
            var checkout = new Checkout();
            checkout.Scan("A");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(50, total);
        }

        [Test]
        public void CanScanItemB()
        {
            var checkout = new Checkout();
            checkout.Scan("B");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(30, total);
        }

        [Test]
        public void CanScanItemC()
        {
            var checkout = new Checkout();
            checkout.Scan("C");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(20, total);
        }

        [Test]
        public void CanScanItemD()
        {
            var checkout = new Checkout();
            checkout.Scan("D");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(15, total);
        } 

        #endregion

        [Test]
        public void CanScanAllItems()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(115, total);
        }

        [Test]
        public void CanScanMultiBuy()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            var total = checkout.GetTotalPrice();

            Assert.AreEqual(130, total);
        }
    }
}