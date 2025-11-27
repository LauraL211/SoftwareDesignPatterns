using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE_Laura_Looney_SD
{
    public class LowStockObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            var stockSubject = subject as StockSubject;
            if (stockSubject == null)
            {
                return;
            }

            Stock stock = stockSubject.LastChangedStock;
            if(stock == null) 
            { 
                return; 
            }
            if (stock.getQuantity() <= stock.getReorderLvl())
            {
               MessageBox.Show($"Alert: Stock '{stock.getName()}' (ID: {stock.getStockID()}) is low. Current Quantity: {stock.getQuantity()}, Reorder Level: {stock.getReorderLvl()}. Please consider replenishing the stock.", "Low Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
