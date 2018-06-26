using System;

namespace ToDo
{
    internal class SQLiteCommand
    {
        private string createTableQuery;
        private SQLiteConnection sqlite;

        public SQLiteCommand(string createTableQuery, SQLiteConnection sqlite)
        {
            this.createTableQuery = createTableQuery;
            this.sqlite = sqlite;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal SQLiteDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}