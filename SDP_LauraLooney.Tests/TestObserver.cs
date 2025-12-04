using RE_Laura_Looney_SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsObserver
{
    public class TestObserver : IObserver
    {
        public int NotificationCount { get; private set; } = 0;
        public Stock LastStock { get; private set; }

        public void Update(ISubject subject)
        {
            NotificationCount++;
            
            if(subject is StockSubject stockSubject)
            {
                LastStock = stockSubject.LastChangedStock;
            }
        }
    }
}
