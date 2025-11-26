using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
     class Order
    {
        private int orderid;
        private String status;
        private DateTime orderdate;
        private decimal totalprice;
        private int custid;
        
        public Order()
        {
            this.orderid = 0;
            this.status = "O";
            this.orderdate = DateTime.Today;
            this.totalprice = 0;
            this.custid = 0;
            
        }

        public Order(int OrderID, String status, DateTime orderdate, decimal totalprice, int custid)
        {
            this.orderid = OrderID;
            this.status = status;
            this.orderdate = orderdate;
            this.totalprice = totalprice;
            this.custid = custid;
        }

        //getters
        public int getOrderID() { return this.orderid; }
        public String getStatus() { return this.status; }
        public DateTime getDate() { return this.orderdate; }
        public decimal getTotalPrice() { return this.totalprice; }
        public int getCustID() { return this.custid; }

        //setters
        public void setOrderID(int OrderID) { orderid = OrderID; }
        public void setStatus(String Status) { status = Status; }
        public void setDate(DateTime OrderDate) { orderdate = OrderDate; }
        public void setPrice(Decimal TotalPrice) { totalprice = TotalPrice; }
        public void setCustID(int CustID) { custid = CustID; }
        
        public static int getNextOrderID()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT MAX(ORDERID) FROM ORDERS";

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

        public void updateStatus()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "UPDATE ORDERS SET " +
                "Status = '" + this.status + "'" +
                "WHERE ORDERID = " + this.orderid;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }
        public void addOrder()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            string formattedDate = this.orderdate.ToString("yyyy-MM-dd");

            String sqlQuery = "INSERT INTO ORDERS(ORDERID, STATUS, ORDERDATE, TOTALPRICE, CUSTID) VALUES('" +
                               this.orderid + "','" +
                               this.status + "', TO_DATE('" +
                               formattedDate + "', 'YYYY-MM-DD'), '" +
                               this.totalprice + "','" +
                               this.custid +
                                "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public static DataSet GetAnOrder(String Search)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT ORDERID, TOTALPRICE, CUSTID FROM ORDERS WHERE ORDERID = '" + Search + "' AND STATUS = 'O' ";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            DBManager.Instance.CloseConnection();

            return ds;
        }

        public void GetOrder(String Search)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT TOTALPRICE FROM ORDERS WHERE ORDERID = '" + Search + "'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setPrice(dr.GetInt32(0));

            DBManager.Instance.CloseConnection();
        }
    }

    
}
