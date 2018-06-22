using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace ToDo
{
    class Todo : ITodo
    {
        private int id;
        private string text;
        private DateTime createdAt;
        private DateTime completedAt;
        private bool isDone;

        public Todo(string text, DateTime completedAt)
        {
            this.Text = text;
            this.CreatedAt = DateTime.Now;
            this.CompletedAt = completedAt;
        }

        public Todo()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Text { get => text; set => text = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime CompletedAt { get => completedAt; set => completedAt = value; }
        public bool IsDone { get => isDone; set => isDone = value; }

        public override string ToString()
        {
            return $"{id} text {text} created at {createdAt.Day}";
        }

        public void IsCompleted()
        {
            isDone = completedAt <= DateTime.Now;
        }

        public int ComplitionTime()
        {
            int completedAtInDays = completedAt.Day + completedAt.Month * 30 + completedAt.Year * 365;
            int actualDateInDays = DateTime.Now.Day + DateTime.Now.Month * 30 + DateTime.Now.Year * 365;

            return completedAtInDays - actualDateInDays;
        }

        public void Save(ITodo newTask)
        {
            using (var sqlite = new SQLiteConnection("Data Source = " + Program.databasePath))
            {
                sqlite.Open();
                string sql = $"INSERT INTO todo (id, text, completedAt, createdAt) SELECT {newTask.Text}, {newTask.CompletedAt}, {newTask.CreatedAt}";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }

        public void SaveAll(List<ITodo> todos)
        {
            using (var sqlite = new SQLiteConnection("Data Source=" + Program.databasePath))
            {
                sqlite.Open();
                foreach (var newTask in todos)
                {
                    string sql = $"INSERT INTO todo (id, text, completedAt, createdAt) SELECT {newTask.Text}, {newTask.CompletedAt}, {newTask.CreatedAt}";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTextInDB(string newText)
        {
            using (var sqlite = new SQLiteConnection("Data Source=" + Program.databasePath))
            {
                sqlite.Open();
                string sql = $"UPDATE todo SET column1={newText} WHERE text={text}";
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
            text = newText;
        }
       
    }
}
