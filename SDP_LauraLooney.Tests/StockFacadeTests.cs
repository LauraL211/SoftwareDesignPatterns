using Microsoft.VisualStudio.TestTools.UnitTesting;
using RE_Laura_Looney_SD;
using TestsObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFacadeTest
{
    [TestClass]
    public class StockFacadeTests
    {
        [TestMethod]
        public void ReplenishStock_RaiseObserverNotification()
        {
            int existingStockID = 1;
            int newQuantity = 50;

            var facade = new StockFacade();
            var observer = new TestObserver();
            facade.Subject.Attach(observer);

            facade.ReplenishStock(existingStockID, newQuantity);

            Assert.AreEqual(1, observer.NotificationCount);
            Assert.IsNotNull(observer.LastStock);
            Assert.AreEqual(existingStockID, observer.LastStock.getStockID());
        }
    }
}
