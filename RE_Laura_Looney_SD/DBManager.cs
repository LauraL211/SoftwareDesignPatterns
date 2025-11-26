using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace RE_Laura_Looney_SD
{
    public class DBManager
    {
        private static DBManager _instance;
        private static readonly object _lock = new object();
        private OracleConnection _connection;

        private DBManager()
        {
            _connection = new OracleConnection(DBConnect.oraDB);
        }

        public static DBManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DBManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public OracleConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
