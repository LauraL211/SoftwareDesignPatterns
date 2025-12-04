using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
    public abstract class StockCreator
    {
        public abstract Stock CreateStock(
            int stockID,
            string name,
            string description,
            string type,
            decimal price,
            int quantity,
            int reorderLevel,
            string status);
    }

    public class AlcoholicStockFactory : StockCreator
    {
        public override Stock CreateStock(
            int stockID,
            string name,
            string description,
            string type,
            decimal price,
            int quantity,
            int reorderLevel,
            string status)
        {
            Stock stock;

            switch (type)
            {
                case "Whiskey":
                    stock = new WhiskeyStock();
                    break;

                case "Vodka":
                   stock = new VodkaStock();
                    break;

                case "Rum":
                    stock = new RumStock();
                    break;

                case "Red Wine":
                    stock = new RedWineStock();
                    break;

                case "White Wine":
                    stock = new WhiteWineStock();
                    break;

                default:
                    stock = new Stock();
                    break;
            }

            stock.setStockID(stockID);
            stock.setName(name);
            stock.setDescription(description);
            stock.setType(type);
            stock.setPrice(price);
            stock.setQuantity(quantity);
            stock.setReorderLvl(reorderLevel);
            stock.setStatus(status);

            return stock;
        }
    }
}
