using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(ORDERID) FROM ORDERS";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public void addOrder()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO ORDERS(ORDERID, STATUS, ORDERDATE, TOTALPRICE, CUSTID) Values('" +
                this.orderid + "','" +
                this.status + "','" +
                this.orderdate + "','" +
                this.totalprice + "','" +
                this.custid + "'" +
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
