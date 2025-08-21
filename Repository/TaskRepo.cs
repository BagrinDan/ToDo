using System;
using Models;
using System.Collections.Generic;

namespace Repository{
    public class TaskRepo{
        private List<TaskModel> TaskList;

        public TaskRepo(){
            TaskList = new List<TaskModel>();
        }

        public IReadOnlyList<TaskModel> GetTaskList(){
            return TaskList.AsReadOnly();
        }
    }
}