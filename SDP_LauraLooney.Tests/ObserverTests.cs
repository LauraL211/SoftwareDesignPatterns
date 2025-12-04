using Microsoft.VisualStudio.TestTools.UnitTesting;
using RE_Laura_Looney_SD;
using TestsObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTests
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        public void OnStockChanged() 
        {
            var subject = new StockSubject();
            var observer = new TestObserver();
             subject.Attach(observer);

            var stock = new Stock();
            stock.setStockID(200);
            stock.setName("Test Name");
            stock.setQuantity(3);
            stock.setReorderLvl(10);

            subject.OnStockChanged(stock);

            Assert.AreEqual(1, observer.NotificationCount);
            Assert.IsNotNull(observer.LastStock);
            Assert.AreEqual(200, observer.LastStock.getStockID());
        }
    }
}
