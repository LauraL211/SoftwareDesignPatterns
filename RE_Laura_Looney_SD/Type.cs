using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
     class Type
    {
        String type;
        String meaning;

        public Type(string Type, string meaning)
        {
            this.type = Type;
            this.meaning = meaning;
        }

        public static DataSet getType()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Type ORDER BY Type";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "type");

            //Close db connection
            conn.Close();

            return ds;
        }
    }
}
