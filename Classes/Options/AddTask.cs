using System;
using Interfaces;
using Models;
using Repository;

namespace Options{
    public class AddTask : IToDoOptions{
        TaskRepo taskRepo = new TaskRepo();
        public void executeOption(TaskModel model){
            taskRepo.GetTaskList().Add(model);
        }
    }
}