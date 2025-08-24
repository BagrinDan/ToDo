using Interfaces;
using Models;

namespace Options{
    public class DeleteTask : IToDoOptions{
        ITaskRepo _taskRepo;

        public DeleteTask(ITaskRepo _taskRepo){
            this._taskRepo = _taskRepo;
        }

        // 1. Delete
        public void executeOption(){
            
        }

    }
}