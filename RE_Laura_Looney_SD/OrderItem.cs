using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
    class OrderItem
    {
        private int orderitemid;
        private int stockid;
        private int orderid;
        private decimal price;
        private int quantity;
        

        public OrderItem()
        {
            this.orderitemid = 0;
            this.stockid = 0;
            this.orderid = 0;
            this.price = 0;
            this.quantity = 0;
        }

        public OrderItem(int OrderItemID, int OrderID, int stockid, decimal price, int quantity )
        {
            this.orderitemid = OrderItemID;
            this.orderid = OrderID;
            this.stockid = stockid;
            this.price = price;
            this.quantity = quantity;
        }

        //getters
        public int getOrderItemID() { return orderitemid; }
        public int getOrderID() { return this.orderid; }
        public int getStockID() { return this.stockid; }
        public decimal getPrice() { return this.price; }
        public int getQuantity() { return this.quantity; }

        //setters
        public void setOrderItemID(int OrderItemID) { orderitemid = OrderItemID;}
        public void setOrderID(int OrderID) { orderid = OrderID; }
        public void setStockID(int StockID) { stockid = StockID; }
        public void setPrice(Decimal Price) { price = Price; }
        public void setQuantity(int Quantity) {  quantity = Quantity; }

        public static int getNextOrderItemID()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT MAX(OrderItemID) FROM ORDERITEMS";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            DBManager.Instance.CloseConnection();

            return nextId;
        }
        public void addItem()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "INSERT INTO ORDERITEMS(ORDERITEMID, STOCKID, ORDERID, PRICE, QUANTITY) VALUES ('" +
                                this.orderitemid + "','" +
                                this.stockid + "','" +
                                this.orderid + "', '" +
                                this.price + "','" +
                                this.quantity + "'" + 
                                ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public static DataSet GetOrder(String Search)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT STOCKID, PRICE, QUANTITY FROM ORDERITEMS WHERE ORDERID = '" + Search + "' ORDER BY STOCKID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            DBManager.Instance.CloseConnection();

            return ds;
        }
    }
}
