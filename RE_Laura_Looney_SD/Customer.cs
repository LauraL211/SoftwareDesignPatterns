using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_Laura_Looney_SD
{
    class Customer
    {
        private int custid;
        private String username;
        private String password;
        private String forename;
        private String surname;
        private int phone;
        private String status;


        public Customer()
        {
            this.custid = 0;
            this.username = "";
            this.password = "";
            this.forename = "";
            this.surname = "";
            this.phone = 0;
            this.status = "O";
        }

        public Customer(int CustID, String username, String password, String forename, String surname, int phone, String status)
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
        public int getPhone() { return this.phone; }
        public String getStatus() { return this.status; }

        //setters
        public void setCustID(int CustID) { custid = CustID; }
        public void setUsername(String Username) { username = Username; }
        public void setPassword(String Password) { password = Password; }
        public void setForename(String Forename) { forename = Forename; }
        public void setSurname(String Surname) { surname = Surname; }
        public void setPhone(int Phone) { phone = Phone; }
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
            setPhone(dr.GetInt32(5));
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
            String sqlQuery = "UPDATE CUSTOMER SET " +
                "CustId = " + this.custid + "," +
                "Username = '" + this.username + "'," +
                "Password = '" + this.password + "'," +
                "Forename = '" + this.forename + "'," +
                "Surname = " + this.surname + "," +
                "Phone = " + this.phone + "," +
                "Status = '" + this.status + "' " +
                "WHERE CustID = " + this.custid;

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
            String sqlQuery = "SELECT CustkId, Forename, Surname, Phone FROM Customers " +
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
    }
}
