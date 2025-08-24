using System;
using System.Collections.Generic;
using Models;

namespace Interfaces{
    public interface ITaskRepo{
        void AddTask(TaskModel model);
        void DeleteTask(TaskModel model);
        int IdIncrementMethod();
        IReadOnlyList<TaskModel> GetTaskList();
    }
}