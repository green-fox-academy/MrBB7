using System;

namespace ToDo
{
    internal class SQLiteConnection : IDisposable
    {
        private string v;

        public SQLiteConnection(string v)
        {
            this.v = v;
        }
    }
}