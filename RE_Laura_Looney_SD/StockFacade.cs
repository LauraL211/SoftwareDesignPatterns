using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
    class StockFacade
    {
        private readonly StockCreator _stockCreator;

        public StockFacade()
        {
            _stockCreator = new AlcoholicStockFactory();
        }

        //Create
        public void AddStock(
            int stockID,
            string stockName,
            string description,
            string type,
            decimal price,
            int quantity,
            int reorderLevel,
            string status)

        { Stock stock = _stockCreator.CreateStock(
                stockID,
                stockName,
                description,
                type,
                price,
                quantity,
                reorderLevel,
                status);
            stock.addStock();
        }

        //Update
        public void UpdateStock(
            int stockID,
            string stockName,
            string description,
            string type,
            decimal price,
            int quantity,
            int reorderLevel,
            string status)
        {
            Stock stock = _stockCreator.CreateStock(
                stockID,
                stockName,
                description,
                type,
                price,
                quantity,
                reorderLevel,
                status);
            stock.updateStock();
        }

        //Delete
        public void DeleteStock(
            int stockID,
            string stockName,
            string description,
            string type,
            decimal price,
            int quantity,
            int reorderLevel,
            string status)
        {
            Stock stock = _stockCreator.CreateStock(
                stockID,
                stockName,
                description,
                type,
                price,
                quantity,
                reorderLevel,
                "U");
            stock.updateStock();
        }

        //Searches
        public DataSet GetAllStocks()
        {
            return Stock.getAllStock();
        }

        public DataSet GetStockByType(string type)
        {
            return Stock.getAllStock(type);
        }

        public DataSet GetStock(string searchTerm)
        {
            return Stock.GetStock(searchTerm);
        }

        public DataSet GetAvailableStock(string searchTerm)
        {
            return Stock.GetAvailableStock(searchTerm);
        }
        public DataSet GetLowStockItems(string searchTerm)
        {
            return Stock.GetLowStock(searchTerm);
        }

        //Replenish Stock
        public void ReplenishStock(int stockID, int quantity)
        {
            Stock stock = new Stock();
            stock.setStockID(stockID);
            stock.Replenish(quantity);
        }
    }
}
