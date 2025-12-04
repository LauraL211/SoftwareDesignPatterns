using Microsoft.VisualStudio.TestTools.UnitTesting;
using RE_Laura_Looney_SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFactoryTests
{
    [TestClass]
    public class StockFactoryTests
    {
        [TestMethod]
        public void CreateStock_WithWhiskeyType_ReturnWhiskeyStock()
        {
            StockCreator creator = new AlcoholicStockFactory();

            Stock stock = creator.CreateStock(
                stockID: 100,
                name: "Jameson",
                description: "Irish Whiskey",
                type: "Whiskey",
                price: 30,
                quantity: 20,
                reorderLevel: 6,
                status: "A");

            Assert.IsInstanceOfType(stock, typeof(WhiskeyStock));
            Assert.AreEqual("Jameson", stock.getName());
            Assert.AreEqual("Irish Whiskey", stock.getDescription());
            Assert.AreEqual("Whiskey", stock.getType());
        }
        [TestMethod]
        public void CreateStock_WithVodkaType_ReturnVodkaStock()
        {
            StockCreator creator = new AlcoholicStockFactory();

            Stock stock = creator.CreateStock(
                stockID: 100,
                name: "Smirnoff",
                description: "Original Vodka",
                type: "Vodka",
                price: 30,
                quantity: 20,
                reorderLevel: 6,
                status: "A");

            Assert.IsInstanceOfType(stock, typeof(VodkaStock));
            Assert.AreEqual("Smirnoff", stock.getName());
            Assert.AreEqual("Original Vodka", stock.getDescription());
            Assert.AreEqual("Vodka", stock.getType());
        }

        [TestMethod]
        public void CreateStock_WithRumType_ReturnRumStock()
        {
            StockCreator creator = new AlcoholicStockFactory();

            Stock stock = creator.CreateStock(
                stockID: 100,
                name: "Rumble",
                description: "Irish Rum",
                type: "Rum",
                price: 30,
                quantity: 20,
                reorderLevel: 6,
                status: "A");

            Assert.IsInstanceOfType(stock, typeof(RumStock));
            Assert.AreEqual("Rumble", stock.getName());
            Assert.AreEqual("Irish Rum", stock.getDescription());
            Assert.AreEqual("Rum", stock.getType());
        }

        [TestMethod]
        public void CreateStock_WithWhiteWineType_ReturnWhiteWineStock()
        {
            StockCreator creator = new AlcoholicStockFactory();

            Stock stock = creator.CreateStock(
                stockID: 100,
                name: "Voila",
                description: "Pinot Grigio",
                type: "White Wine",
                price: 30,
                quantity: 20,
                reorderLevel: 6,
                status: "A");

            Assert.IsInstanceOfType(stock, typeof(WhiteWineStock));
            Assert.AreEqual("Voila", stock.getName());
            Assert.AreEqual("Pinot Grigio", stock.getDescription());
            Assert.AreEqual("White Wine", stock.getType());
        }

        [TestMethod]
        public void CreateStock_WithRedWineType_ReturnRedWineStock()
        {
            StockCreator creator = new AlcoholicStockFactory();

            Stock stock = creator.CreateStock(
                stockID: 100,
                name: "Rouge",
                description: "Merlot",
                type: "Red Wine",
                price: 30,
                quantity: 20,
                reorderLevel: 6,
                status: "A");

            Assert.IsInstanceOfType(stock, typeof(RedWineStock));
            Assert.AreEqual("Rouge", stock.getName());
            Assert.AreEqual("Merlot", stock.getDescription());
            Assert.AreEqual("Red Wine", stock.getType());
        }
    }
}
