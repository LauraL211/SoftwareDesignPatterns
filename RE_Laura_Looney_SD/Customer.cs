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
    class Customer
    {
        private int custid;
        private String username;
        private String password;
        private String forename;
        private String surname;
        private String phone;
        private String status;


        public Customer()
        {
            this.custid = 0;
            this.username = "";
            this.password = "";
            this.forename = "";
            this.surname = "";
            this.phone = "";
            this.status = "O";
        }

        public Customer(int CustID, String username, String password, String forename, String surname, String phone, String status)
        {
            this.custid = CustID;
            this.username = username;
            this.password = password;
            this.forename = forename;
            this.surname = surname;
            this.phone = phone;
            this.status = status;

        }

        //getters
        public int getCustID() { return this.custid; }
        public String getUserame() { return this.username; }
        public String getPassword() { return this.password; }
        public String getForename() { return this.forename; }
        public String getSurname() { return this.surname; }
        public String getPhone() { return this.phone; }
        public String getStatus() { return this.status; }

        //setters
        public void setCustID(int CustID) { custid = CustID; }
        public void setUsername(String Username) { username = Username; }
        public void setPassword(String Password) { password = Password; }
        public void setForename(String Forename) { forename = Forename; }
        public void setSurname(String Surname) { surname = Surname; }
        public void setPhone(String Phone) { phone = Phone; }
        public void setStatus(String Status) { status = Status; }

        public static DataSet getAllCustomers()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CustID, Forename, Surname, Phone " +
                "FROM Customers ORDER BY Surname";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "stock");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getAllCustomers(String Status)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CustID, Forename, Surname, Phone " +
                "FROM Customers WHERE Status = '" + Status + "' ORDER BY Surname";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "customers");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getCustomer(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Customers WHERE CustID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setCustID(dr.GetInt32(0));
            setUsername(dr.GetString(1));
            setPassword(dr.GetString(2));
            setForename(dr.GetString(3));
            setSurname(dr.GetString(4));
            setPhone(dr.GetString(5));
            setStatus(dr.GetString(7));

            //close DB
            conn.Close();
        }
        public void addCustomer()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO CUSTOMERS(CustID, Username, Password, Forename, Surname, Phone, Status) Values('" +
                this.custid + "','" +
                this.username + "','" +
                this.password + "','" +
                this.forename + "','" +
                this.surname + "','" +
                this.phone + "','" +
                this.status +
                "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateCustomer()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE CUSTOMERS SET " +
                              "FORENAME = '" + this.forename + "', " +
                              "SURNAME = '" + this.surname + "', " +
                              "PHONE = '" + this.phone + "' " +
                              "WHERE CUSTID = '" + this.custid +"'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void deleteCustomer() 
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE CUSTOMERS SET " +
                              "STATUS = 'C'" +
                              "WHERE CUSTID = '" + this.custid + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findCustomer(String CustomerName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CustId, Forename, Surname, Phone FROM Customers " +
                "WHERE Forename LIKE '%" + CustomerName + "%' ORDER BY Surname";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "customers");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static int getNextCustID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(CustID) FROM CUSTOMERS";

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


        public bool CheckCustomer(String username, String password)
        {
            bool valid = false;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT COUNT(*) FROM CUSTOMERS WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "' AND STATUS = 'O'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            int resultCount = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultCount > 0)
            {
                MessageBox.Show("Hello, " + username, "Welcome :)",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

              
               valid = true;
            }
            else
            {
           
               valid = false;
            }

            conn.Close();
            return valid;
        }

        public void FindingCustomer(String name)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String sqlQuery = "SELECT CUSTID, FORENAME, SURNAME, PHONE FROM CUSTOMERS WHERE USERNAME = '" + name + "' ";
            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setCustID(dr.GetInt32(0));
            setForename(dr.GetString(1));
            setSurname(dr.GetString(2));
            setPhone(dr.GetString(3));

            //close DB
            conn.Close();

        }
    }
}
