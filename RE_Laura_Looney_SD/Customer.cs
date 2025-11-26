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

        public void getCustomerID(int Id)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT FORENAME, SURNAME FROM CUSTOMERS WHERE CustID = " + Id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setForename(dr.GetString(0));
            setSurname(dr.GetString(1));

            DBManager.Instance.CloseConnection();
        }
        public void addCustomer()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "INSERT INTO CUSTOMERS(CustID, Username, Password, Forename, Surname, Phone, Status) Values('" +
                this.custid + "','" +
                this.username + "','" +
                this.password + "','" +
                this.forename + "','" +
                this.surname + "','" +
                this.phone + "','" +
                this.status +
                "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public void updateCustomer()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "UPDATE CUSTOMERS SET " +
                              "FORENAME = '" + this.forename + "', " +
                              "SURNAME = '" + this.surname + "', " +
                              "PHONE = '" + this.phone + "' " +
                              "WHERE CUSTID = '" + this.custid +"'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public void deleteCustomer() 
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "UPDATE CUSTOMERS SET " +
                              "STATUS = 'C'" +
                              "WHERE CUSTID = '" + this.custid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.ExecuteNonQuery();

            DBManager.Instance.CloseConnection();
        }

        public static int getNextCustID()
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT MAX(CustID) FROM CUSTOMERS";

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


        public bool CheckCustomer(String username, String password)
        {
            bool valid = false;
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT COUNT(*) FROM CUSTOMERS WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "' AND STATUS = 'O'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

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

            DBManager.Instance.CloseConnection();
            return valid;
        }

        public void FindingCustomer(String name)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();

            String sqlQuery = "SELECT CUSTID, FORENAME, SURNAME, PHONE FROM CUSTOMERS WHERE USERNAME = '" + name + "' ";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setCustID(dr.GetInt32(0));
            setForename(dr.GetString(1));
            setSurname(dr.GetString(2));
            setPhone(dr.GetString(3));

            DBManager.Instance.CloseConnection();

        }
    }
}
