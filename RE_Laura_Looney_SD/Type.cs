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
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT * FROM TYPES WHERE TYPECODE = '" + TypeCode + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();


            setTypecode(dr.GetString(0));
            setDescription(dr.GetString(1));
            setStatus(dr.GetString(2));

            conn.Close();
        }

        public void addType()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "INSERT INTO Types(Typecode, Description, Status) Values('" +
                this.typecode + "','" +
                this.description + "','" +
                this.status +
                "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

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

        public void  CheckData(String stocktype)
        {
          
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT COUNT(*) FROM STOCK WHERE TYPE = '" + stocktype + "'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            int resultCount = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultCount > 0)
            {
                    MessageBox.Show("Stock Type can not be delted as stock contain that type", "Not Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                 sqlQuery = "DELETE FROM Types WHERE DESCRIPTION = " + stocktype;
                 cmd = new OracleCommand(sqlQuery, conn);

                MessageBox.Show("Stock Type deleted successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();


        }
    } }
    
