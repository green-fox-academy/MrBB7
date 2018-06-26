using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace ToDo
{
    public class ReadDataBase
    {

        public static ITodo Load(int id)
        {
            Todo newItem = new Todo();
            using (var sqlite = new SQLiteConnection("Data Source="+ Program.databasePath))
            {
                sqlite.Open();
                string sql = $"SELECT * FROM todo WHERE id = {id}";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                newItem = GenerateTodo(command.ExecuteReader());
            }
            return newItem;
        }

        public static ITodo Load(string text)
        {
            Todo newItem = new Todo();
            using (var sqlite = new SQLiteConnection("Data Source=" + Program.databasePath))
            {
                sqlite.Open();
                string sql = $"SELECT * FROM todo WHERE text = {text}";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                newItem = GenerateTodo(command.ExecuteReader());
            }
            return newItem;
        }

        public static List<ITodo> LoadAll()
        {
            List<ITodo> newItems = new List<ITodo>();
            using (var sqlite = new SQLiteConnection("Data Source=" + Program.databasePath))
            {
                sqlite.Open();
                string sql = "SELECT * FROM todo";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                
                var listOfElements = command.ExecuteReader().GetEnumerator();
                do
                {
                    var asd = listOfElements.Current.GetType();
                    int a;
                    a = 10;
                    newItems.Add(GenerateTodo((SQLiteDataReader)listOfElements.Current));
                }
                while (listOfElements.MoveNext());
            }
            return newItems;
        }

        private static Todo GenerateTodo(SQLiteDataReader dbItem)
        {
            Todo newItem = new Todo();
            newItem.Id = dbItem.GetInt32(0);
            newItem.Text = dbItem.GetString(1);
            newItem.CreatedAt = dbItem.GetDateTime(2);
            newItem.CompletedAt = dbItem.GetDateTime(3);
            newItem.IsCompleted();
            return newItem;
        }
    }
}
