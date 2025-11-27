using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE_Laura_Looney_SD
{
    public class Stock
    {
        private int stockid;
        private String name;
        private String description;
        private String type;
        private decimal price;
        private int quantity;
        private int reorderlvl;
        private String status;


        public Stock()
        {
            this.stockid = 0;
            this.name = "";
            this.description = "";
            this.type = "";
            this.price = 0;
            this.quantity = 0;
            this.reorderlvl = 0;
            this.status = "A";
        }

        public Stock(int StockID, String name, String description, String type, decimal price, int quantity, int reorderlvl, String status)
        {
            this.stockid = StockID;
            this.name = name;
            this.description = description;
            this.type = type;
            this.price = price;
            this.quantity = quantity;
            this.reorderlvl = reorderlvl;
            this.status = status;

        }

        //getters
        public int getStockID() { return this.stockid; }
        public String getName() { return this.name; }
        public String getDescription() { return this.description; }
        public String getType() { return this.type; }
        public decimal getPrice() { return this.price; }
        public int getQuantity() { return this.quantity; }
        public int getReorderLvl() { return this.reorderlvl; }
        public String getStatus() { return this.status; }

        //setters
        public void setStockID(int StockID) { stockid = StockID; }
        public void setName(String Name) { name = Name; }
        public void setDescription(String Description) { description = Description; }
        public void setType(String Type) { type = Type; }
        public void setPrice(Decimal Price) { price = Price; }
        public void setQuantity(int Quantity) { quantity = Quantity; }
        public void setReorderLvl(int ReorderLvl) { reorderlvl = ReorderLvl; }
        public void setStatus(String Status) { status = Status; }

        

        public static DataSet getAllStock()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT StockID, Name, Price, Quantity " +
                "FROM Stock ORDER BY Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            DBManager.Instance.CloseConnection();

            return ds;
        }
        public static DataSet getAllStock(String Type)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT StockID, Name, Price, Quantity " +
                "FROM Stock WHERE Type = '" + Type + "' ORDER BY Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            DBManager.Instance.CloseConnection();

            return ds;
        }

        public void getStock( int stockId)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT * FROM Stock WHERE StockID = " + stockId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setStockID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setType(dr.GetString(3));
            setPrice(dr.GetDecimal(4));
            setQuantity(dr.GetInt32(5));
            setReorderLvl(dr.GetInt32(6));
            setStatus(dr.GetString(7));

            DBManager.Instance.CloseConnection();
        }
        public void addStock()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "INSERT INTO STOCK(STOCKID, NAME, DESCRIPTION, TYPE, PRICE, QUANTITY, REORDERLVL, STATUS) Values('" +
                this.stockid + "','" +
                this.name + "','" +
                this.description + "','" +
                this.type + "'," +
                this.price + "," +
                this.quantity  + "," +
                this.reorderlvl  + ", '" +
                this.status + 
                "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public void updateStock()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "UPDATE STOCK SET " +
                "StockId = " + this.stockid + "," +
                "Name = '" + this.name + "'," +
                "Description = '" + this.description + "'," +
                "Type = '" + this.type + "'," +
                "Price = " + this.price + "," +
                "Quantity = " + this.quantity + "," +
                "ReorderLvl = '" + this.reorderlvl + "'," +
                "Status = '" + this.status + "'" +
                "WHERE StockID = " + this.stockid;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public static DataSet findStock(String StockName)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT StockId, Name, Type FROM Stock " +
                "WHERE Name LIKE '%" + StockName + "%' ORDER BY Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            DBManager.Instance.CloseConnection();

            return ds;
        }
        public static int getNextStockID()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();
            String sqlQuery = "SELECT MAX(StockID) FROM STOCK";
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

        public static DataSet GetStock(String Search)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT STOCKID, NAME, DESCRIPTION FROM STOCK WHERE NAME LIKE '%" + Search +"%' ORDER BY STOCKID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            DBManager.Instance.CloseConnection();

            return ds;
        }

        //Attempt at replenish stock
        public void  replenishStock(int stockId)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT STOCKID, NAME, DESCRIPTION, QUANTITY, PRICE FROM STOCK WHERE StockID = " + stockId;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setStockID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setQuantity(dr.GetInt32(3));
            setPrice(dr.GetDecimal(4));

            DBManager.Instance.CloseConnection();

        }

        public static DataSet GetAvailableStock(String Search)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT STOCKID, NAME, DESCRIPTION FROM STOCK WHERE NAME LIKE '%" + Search + "%' AND STATUS != 'U' ORDER BY STOCKID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            DBManager.Instance.CloseConnection();

            return ds;
        }

        public static DataSet GetLowStock(String Search)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT STOCKID, NAME, DESCRIPTION FROM STOCK WHERE NAME LIKE '%" + Search + "%' AND QUANTITY<REORDERLVL ORDER BY STOCKID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            DBManager.Instance.CloseConnection();

            return ds;
        }

        public static List<string> GetAllTypes()
        {
            var types = new List<string>();

            OracleConnection conn = DBManager.Instance.GetConnection();
            string sqlQuery = "SELECT DESCRIPTION FROM TYPES";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                types.Add(reader.GetString(0));
            }

            reader.Close();
            DBManager.Instance.CloseConnection();

            return types;
        }

        public static DataSet CheckStock()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT * FROM STOCK WHERE REORDERLVL < QUANTITY ORDER BY STOCKID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            DBManager.Instance.CloseConnection();

            return ds;
        }

        public void Replenish(int orderquantity)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "UPDATE STOCK SET " +
                              "QUANTITY = '" + orderquantity + "' " +
                              "WHERE STOCKID = '" + this.stockid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public int StockQuantity(int stockId)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT QUANTITY FROM STOCK WHERE StockID = " + stockId;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setQuantity(dr.GetInt32(0));

            DBManager.Instance.CloseConnection();

            return this.quantity;

        }
        public void updatestockquantity(int orderquantity)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            int currentquantity = 0;

            String sqlQuery = "SELECT QUANTITY" +
                              " FROM STOCK " +
                              " WHERE STOCKID = '" + this.stockid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                currentquantity = reader.GetInt32(0);
            }
            reader.Close();
           
            int newquantity = currentquantity - orderquantity;

            String sqlQuery2 = "UPDATE STOCK SET " +
                              "QUANTITY = '" + newquantity + "' " +
                              "WHERE STOCKID = '" + this.stockid + "'";

            OracleCommand cmd1 = new OracleCommand(sqlQuery2, conn);
            cmd1.ExecuteNonQuery();

            //Close db connection
            DBManager.Instance.CloseConnection();   

        }

        public void updateCancelOrder(int orderquantity)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            int currentquantity = 0;

            String sqlQuery = "SELECT QUANTITY" +
                              " FROM STOCK " +
                              " WHERE STOCKID = '" + this.stockid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                currentquantity = reader.GetInt32(0);
            }
            reader.Close();

            int newquantity = currentquantity + orderquantity;

            String sqlQuery2 = "UPDATE STOCK SET " +
                              "QUANTITY = '" + newquantity + "' " +
                              "WHERE STOCKID = '" + this.stockid + "'";

            OracleCommand cmd1 = new OracleCommand(sqlQuery2, conn);
            cmd1.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();

        }

    }
}
