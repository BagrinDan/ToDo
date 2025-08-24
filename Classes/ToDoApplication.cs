
using Input;
using Interfaces;
using Options;
using Repository;

namespace Classes{
    public class ToDoApplication : IToDoApplication{
        ITaskRepo _taskRepo = new TaskRepo();
        IUserInput _userInput = new UserInput();
        
        public void executeToDo(){
            IToDoOptions createTaskOption = new CreateTask(_taskRepo, _userInput);
            IToDoUI _toDoUI = new ToDoUI(createTaskOption);

            _toDoUI.executeMenu();
        }
    }
}