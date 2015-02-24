using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace KUMPOT_Mobile.util
{
    public class SqlLiteDBComponent
    {
        public SQLiteConnection mySqlConnection;
        //private SqlCeCommand mySqlCommand = null;
        private SQLiteDataAdapter mySqlDataAdapter = null;
        public DataSet myDataSet = null;

        private string myDBName;
        public string DBName
        {
            get
            {
                return myDBName;
            }
            set
            {
                myDBName = value;
            }
        }

        private string myDBPassword;
        public string DBPassword
        {
            get { return myDBPassword; }
            set { myDBPassword = value;}
        }

        private bool myDBEncrypt = true;
        public bool DBEncrypt
        {
            get { return myDBEncrypt; }
            set { myDBEncrypt = value; }
        }

        private bool myDBDelete = false;
        public bool DBDelete
        {
            get
            {
                return myDBDelete;
            }
            set
            {
                myDBDelete = value;
            }
        }
        public void DBCreate()
        {
            string connStr = "Data Source='" + myDBName + "'; LCID=1033; Password=\"" + myDBPassword + "\"; Encrypt = ";
            if (myDBEncrypt == true) connStr += "TRUE;";
            else connStr += "FALSE;";

            if (myDBEncrypt == false && File.Exists(myDBName)) return;
            else File.Delete(myDBName);

            try
            {
                mySqlEngine = new SqlCeEngine(connStr);
                mySqlEngine.CreateDatabase();
            }
            catch
            {

            }
            finally
            {
                mySqlEngine.Dispose();
            }
        }
        public void DBOpen()
        {
            string connStr = "Data Source='" + myDBName + "'; LCID=1033; Password=\"" + myDBPassword + "\"; Encrypt = ";
            if (myDBEncrypt == true) connStr += "TRUE;";
            else connStr += "FALSE;";

            myDataSet = new DataSet();
            mySqlCommand = new SqlCeCommand();
            mySqlDataAdapter = new SqlCeDataAdapter();

            mySqlConnection = new SqlCeConnection(connStr);
            mySqlConnection.Open();
            mySqlCommand.Connection = mySqlConnection;
        }

        // Provides the state of the connection 
        public ConnectionState DBConnectionState()
        {
            return mySqlConnection.State;
        }


        public void DBClose()
        {
            mySqlCommand.Dispose();
            mySqlDataAdapter.Dispose();
            mySqlConnection.Close();
            mySqlConnection.Dispose();
        }

        // Query the database and return the resultset
        public DataSet DBQuery(string queryStr)
        {
            mySqlCommand.CommandText = queryStr;
            myDataSet.Clear();

            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(myDataSet);

            return myDataSet;
        }

        // Execute Delete, Insert and Update commands
        public int DBExecute(string executeStr)
        {
            mySqlCommand.CommandText = executeStr;
            int rowsAffected = mySqlCommand.ExecuteNonQuery();

            return rowsAffected;
        }

    }
}
