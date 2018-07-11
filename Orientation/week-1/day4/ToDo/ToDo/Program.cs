using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ToDo
{
    public class Program
    {
        public static string databasePath = @"E:\GreenFox\MrBB7\week1\day2\greenfox\MrBB7\week-1(Orientation)\day4\ToDo\todoDatabase.sqlite";
        private static List<ITodo> todos = new List<ITodo>();

        static void Main(string[] args)
        {
            ITodo newTodo = new Todo();
            DataBaseCreator();

            if (args[0] == null)
            {
                Console.WriteLine("please write a task");
            }
            else if (args[0] == "-l")
            {
                int idValue = 0;
                if (args[1] == null)
                {
                    todos = ReadDataBase.LoadAll();
                }
                else if (int.TryParse(args[1], out idValue))
                {
                    newTodo = ReadDataBase.Load(idValue);
                }
                else
                {
                    newTodo = ReadDataBase.Load(args[1]);
                }
            }
            else if (args[0] == "-a")
            {
                newTodo.Save(new Todo() { CompletedAt = DateTime.Parse(args[2]), Text = args[1] });
            }
            else if (args[0] == "-u")
            {
                todos = ReadDataBase.LoadAll();
                if (int.Parse(args[1]) < todos.Count)
                {
                    todos[int.Parse(args[1])].UpdateTextInDB(args[2]);
                }
            }
        }

        private static void DataBaseCreator()
        {
            if (File.Exists(databasePath))
            {
                return;
            }

            string createTableQuery = @"CREATE TABLE IF NOT EXISTS  todo(
                                        id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        text NVARCHAR(2048) NULL,
                                        createdat DATETIME NULL,
                                        completedat DATETIME NULL
                                        )";

            System.Data.SQLite.SQLiteConnection.CreateFile(databasePath);
            using (var sqlite = new SQLiteConnection("Data Source=" + Program.databasePath))
            {
                sqlite.Open();
                SQLiteCommand command = new SQLiteCommand(createTableQuery, sqlite);
                command.ExecuteNonQuery();
            }
        }

        private string GetAllText()
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                todos.Where(todo => todo.IsDone).ToList().ForEach(todo => stringBuilder.Append(todo));
                return stringBuilder.ToString();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }

            return null;
        }
    }
}
