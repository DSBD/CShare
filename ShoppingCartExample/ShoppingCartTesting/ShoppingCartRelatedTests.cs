using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartExample;

namespace ShoppingCartTesting
{
    [TestClass]
    public class ShoppingCartRelatedTests
    {
        [TestMethod]
        public void CheckIfItemAddedProperlyToCart()
        {
            var item = new Item()
            {
                Price = 100,
                UpcCode = "33434343443"
            };
            var cart = new ShoppingCart();
            cart.AddItem(item);
            Assert.AreEqual(cart.ItemsCount, 1);

        }

        [TestMethod]
        public void CheckShoppingCartTotal()
        {

            List<Item> items = new List<Item>()
            {
                new Item()
                {
                    Price = 100,
                    UpcCode = "33434343443" 
                },
                new Item()
                {
                    Price = 200,
                    UpcCode = "item2" 
                },
                new Item()
                {
                    Price = 300,
                    UpcCode = "item3" 
                },
            };

            var shoppingCart = new ShoppingCart();
            shoppingCart.Items = items;
            Assert.AreEqual(shoppingCart.CalculateTotal() , 600);
        }

    }
}
