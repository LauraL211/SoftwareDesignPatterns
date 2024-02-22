using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
    class Stock
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
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT StockID, Name, Price, Quantity " +
                "FROM Stock ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getAllStock(String Type)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT StockID, Name, Price, Quantity " +
                "FROM Stock WHERE Type = '" + Type + "' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getStock(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Stock WHERE StockID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setStockID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setType(dr.GetString(3));
            setPrice(dr.GetInt32(4));
            setQuantity(dr.GetInt32(5));
            setReorderLvl(dr.GetInt32(6));
            setStatus(dr.GetString(7));

            //close DB
            conn.Close();
        }
        public void addStock()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO STOCK(StockID, Name, Description, Type, Price, Quantity, ReorderLVL, Status) Values('" +
                this.stockid + "','" +
                this.name.ToLower() + "','" +
                this.description.ToLower() + "','" +
                this.type.ToLower() + "'," +
                this.price + "," +
                this.quantity + ",'" +
                this.reorderlvl + "','" +
                this.status + 
                "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateStock()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
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

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findStock(String StockName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT StockId, Name, Type FROM Stock " +
                "WHERE Name LIKE '%" + StockName + "%' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static int getNextStockID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(StockID) FROM STOCK";

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

        public static DataSet GetStock(String Search)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT STOCKID, NAME, DESCRIPTION FROM STOCK WHERE NAME LIKE '%" + Search +"%' ORDER BY STOCKID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "StockID");

            conn.Close();

            return ds;
        }
    }
}
