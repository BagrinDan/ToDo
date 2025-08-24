using Interfaces;
using Models;

namespace Options{
    public class CreateTask : IToDoOptions{
        private readonly ITaskRepo _taskRepo;
        private readonly IUserInput _userInput;
        public CreateTask(ITaskRepo _taskRepo, IUserInput _userInput){
            this._taskRepo = _taskRepo;
            this._userInput = _userInput;
        }

        // 1. Add task
        public void executeOption(){
            TaskModel model = new TaskModel();

            model.TaskID = _taskRepo.IdIncrementMethod();

            model.TaskName = _userInput.userInput();

            model.IsCompleted = false;
            
            _taskRepo.AddTask(model);
        }        
    }
}