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
        public String getStatus() { return this.status;}

        //setters
        public void setTypecode(String Typecode) { typecode = Typecode; }
        public void setDescription(String Description) { description = Description; }
        public void setStatus(String Status) {  status = Status; }

        public static DataSet getType()
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
                this.description  + "','" +
                this.status +
                "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
    }
}
