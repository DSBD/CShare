using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartExample;


namespace ShoppingCartTesting
{
    [TestClass]
    public class ItemRelatedTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ItemPriceShouldNotAcceptNegative()
        {
            var item = new Item()
            {
                Price = -10,
                UpcCode = "Test"
            };
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpcCodeShouldNotBeEmpty()
        {
            var item = new Item()
            {
                Price = 10,
                UpcCode = ""
            };
            Assert.Fail();
        }
    }
}
