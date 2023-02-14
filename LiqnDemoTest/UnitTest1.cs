using LinqDemo;

namespace LiqnDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        public void TestMethod1()
        {
            Func<int, int> doubler = x => x * 2;

            Assert.AreEqual(34, doubler(17));
        }

        [TestMethod]
        public void pa()
        {
            Func<double, double, double> RectangleArea = (x, y) => x * y;
            Func<double, double, double> RectanglePerimeter = (x, y) => (x + y) * 2;


            Assert.AreEqual(6, RectangleArea(3, 2));
            Assert.AreEqual(6, RectanglePerimeter(2, 1));
        }

        [TestMethod]
        public void TestIsEven()
        {
            Func<int, bool> isEven = x => x % 2 == 0;
            Assert.IsTrue(isEven(4));
            Assert.IsFalse(isEven(3));
        }

        [TestMethod]
        public void TestIsOdd()
        {
            Func<int, bool> isOdd = x => x % 2 == 1;
            Assert.IsTrue(isOdd(3));
            Assert.IsFalse(isOdd(4));
        }

        [TestMethod]
        public void TestIsDivisibleBy2()
        {
            Func<int, bool> isDivisibleBy2 = x => x % 2 == 0;
            Assert.IsTrue(isDivisibleBy2(6));
            Assert.IsFalse(isDivisibleBy2(5));
        }

        [TestMethod]
        public void TestHelloWorldLambda()
        {
            var helloWorld = () => "Hello World!";
            Assert.AreEqual("Hello World!", helloWorld());
        }
        */

        [TestMethod]
        public void PB()
        {
            var p1 = new Product { Id = 1, Name = "Chaussures", Price = 350.00M, Quantity = 10 };
            var p2 = new Product { Id = 2, Name = "T-shirt", Price = 220.00M, Quantity = 15 };
            var p3 = new Product { Id = 3, Name = "Pantalon", Price = 370.00M, Quantity = 5 };

            List<Product> productList = new List<Product> { p1, p2, p3 };

            List<Product> expected = new List<Product> { p2, p1, p3 };

            productList = productList.OrderBy(p => p.Price).ToList();

            CollectionAssert.AreEqual(expected, productList);


            expected = new List<Product> { p1, p3 };

            productList = productList.Where(p => p.Price > 300).ToList();

            CollectionAssert.AreEqual(expected, productList);
        }
    }
}