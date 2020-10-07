using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CartServiceTest
{
    [TestClass]
    public class CartServiceTest
    {
        [TestMethod]
        public void GetWholeOrderTotalPrice_WithScenario_A_ValidOrderValue()
        {
            // [ Scenario A ] =>
            // 1 * A 50
            // 1 * B 30
            // 1 * C 20
            // [ Total Order Value is: 100 ]

            // Arrange
            double expected = 100;
            ICartService _cartService = new CartService();
            Product prod;

            // Adding 1 A Type Product.
            prod = new Product { Id = "A" };
            _cartService.AddProduct(prod);

            // Adding 1 B Type Product.
            prod = new Product { Id = "B" };
            _cartService.AddProduct(prod);

            // Adding 1 C Type Product.
            prod = new Product { Id = "C" };
            _cartService.AddProduct(prod);

            // Act
            decimal actual = _cartService.GetWholeOrderTotalPrice();

            // Assert 
            Assert.AreEqual(expected, Convert.ToDouble(actual), 0.001, "Total Order Value is valid.");

        }

        [TestMethod]
        public void GetWholeOrderTotalPrice_WithScenario_B_ValidOrderValue()
        {
            // [ Scenario B ] =>
            // 5 * A 130 + 2 * 50
            // 5 * B 45 + 45 + 30
            // 1 * C 20
            // [ Total Order Value is: 370 ]

            // Arrange
            double expected = 370;
            ICartService _cartService = new CartService();
            Product prod;

            // Adding 5 A Type Product.
            for (int i = 0; i < 5; i++)
            {
                prod = new Product { Id = "A" };
                _cartService.AddProduct(prod);
            }

            // Adding 5 B Type Product.
            for (int i = 0; i < 5; i++)
            {
                prod = new Product { Id = "B" };
                _cartService.AddProduct(prod);
            }

            // Adding 1 C Type Product.
            prod = new Product { Id = "C" };
            _cartService.AddProduct(prod);

            // Act                        
            decimal actual = _cartService.GetWholeOrderTotalPrice();

            // Assert 
            Assert.AreEqual(expected, Convert.ToDouble(actual), 0.001, "Total Order Value is valid.");

        }

        [TestMethod]
        public void GetWholeOrderTotalPrice_WithScenario_C_ValidOrderValue()
        {
            // [Scenario C] =>
            // 3 * A 130
            // 5 * B 45 + 45 + 1 * 30
            // 1 * C -
            // 1 * D 15
            // Total Order Value is: 265

            // Arrange
            double expected = 265;
            ICartService _cartService = new CartService();
            Product prod;

            // Adding 3 A Type Product.
            for (int i = 0; i < 3; i++)
            {
                prod = new Product { Id = "A" };
                _cartService.AddProduct(prod);
            }

            // Adding 5 B Type Product.
            for (int i = 0; i < 5; i++)
            {
                prod = new Product { Id = "B" };
                _cartService.AddProduct(prod);
            }

            // Adding 1 D Type Product.
            prod = new Product { Id = "D" };
            _cartService.AddProduct(prod);

            // Act                        
            decimal actual = _cartService.GetWholeOrderTotalPrice();

            // Assert 
            Assert.AreEqual(expected, Convert.ToDouble(actual), 0.001, "Total Order Value is valid.");

        }
    }
}
