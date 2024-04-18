using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
    class OrderItem
    {
        private int stockid;
        private int orderid;
        private decimal price;
        private int quantity;
        

        public OrderItem()
        {
            this.stockid = 0;
            this.orderid = 0;
            this.price = 0;
            this.quantity = 0;
        }

        public OrderItem(int OrderID, int stockid, decimal price, int quantity )
        {
            this.orderid = OrderID;
            this.stockid = stockid;
            this.price = price;
            this.quantity = quantity;
        }

        //getters
        public int getOrderID() { return this.orderid; }
        public int getStockID() { return this.stockid; }
        public decimal getPrice() { return this.price; }
        public int getQuantity() { return this.quantity; }

        //setters
        public void setOrderID(int OrderID) { orderid = OrderID; }
        public void setCustID(int StockID) { stockid = StockID; }
        public void setPrice(Decimal Price) { price = Price; }
        public void setQuantity(int Quantity) {  quantity = Quantity; }

        public void addItem()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO ORDERITEMS(STOCKID, ORDERID, PRICE, QUANTITY) VALUES ('" +
                                this.stockid + "','" +
                                this.orderid + "', '" +
                                this.price + "','" +
                                this.quantity + "'" + 
                                ")";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
    }
}
