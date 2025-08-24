using Interfaces;
using Models;

namespace Options{
    public class PrintTasks : IToDoOptions{
        private readonly ITaskRepo _taskRepo;
        private readonly IUserInput _userInput;
        public PrintTasks(ITaskRepo _taskRepo, IUserInput _userInput){
            this._taskRepo = _taskRepo;
            this._userInput = _userInput;
        }

        //1. 
        public void executeOption(){
            var tasks = _taskRepo.GetTaskList();
            for(int i = 0; i < tasks.Count; i++){
                Console.WriteLine("Task id" + tasks[i].TaskID + ", Task name: " + tasks[i].TaskName + ", Task comp: " + tasks[i].IsCompleted);
            }
        }
    }
}