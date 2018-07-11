using System;
using System.Collections.Generic;

namespace ToDo
{
    public interface ITodo
    {
        int Id { get; set; }
        string Text { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime CompletedAt { get; set; }
        bool IsDone { get; set; }

        void IsCompleted();

        int ComplitionTime();

        void UpdateTextInDB(string newText);

        void Save(ITodo newTask);

        void SaveAll(List<ITodo> todos);

    }
}