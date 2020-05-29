using System;

namespace WindowsFormsApp1
{
    internal class MySqlCommand
    {
        private string sql;
        private MySqlConnection con;

        public MySqlCommand(string sql, MySqlConnection con)
        {
            this.sql = sql;
            this.con = con;
        }

        public MySqlConnection Connection { get; internal set; }
        public string MyCommandText { get; internal set; }

        internal MySqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}