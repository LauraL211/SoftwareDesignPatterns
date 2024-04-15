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
    class Type
    {
        private String typecode;
        private String description;
        private String status;


        public Type()
        {
            this.typecode = "";
            this.description = "";
            this.status = "";
        }

        public Type(String typecode, String description, String status)
        {
            this.typecode = typecode;
            this.description = description;
            this.status = status;
        }

        //getters
        public String getTypecode() { return this.typecode; }
        public String getDescription() { return this.description; }
        public String getStatus() { return this.status; }

        //setters
        public void setTypecode(String Typecode) { typecode = Typecode; }
        public void setDescription(String Description) { description = Description; }
        public void setStatus(String Status) { status = Status; }

        public void GetType(String TypeCode)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM TYPES WHERE TYPECODE = '" + TypeCode + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader

            setTypecode(dr.GetString(0));
            setDescription(dr.GetString(1));
            setStatus(dr.GetString(2));

            //close DB
            conn.Close();
        }

        public static DataSet loadTypes(ComboBox aCombo)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Description FROM Type ORDER BY TypeCode";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "type");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void addType()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Types(Typecode, Description, Status) Values('" +
                this.typecode + "','" +
                this.description + "','" +
                this.status +
                "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet GetStockType(String Search)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT TYPECODE, DESCRIPTION, STATUS FROM TYPES WHERE DESCRIPTION LIKE '%" + Search + "%' ORDER BY TYPECODE";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Typecode");

            conn.Close();

            return ds;
        }

        public void updateType()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE TYPES SET " +
                "TypeCode = '" + this.typecode + "'," +
                "Description = '" + this.description + "'," +
                "Status = '" + this.status + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
    } }
    
