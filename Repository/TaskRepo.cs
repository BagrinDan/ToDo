using Models;
using Interfaces;

namespace Repository{

        /// <summary>
        ///     Repository for tasks
        /// </summary>
    public class TaskRepo : ITaskRepo{
        private List<TaskModel> TaskList;

        public int IdIncrement {get; set; }

        /// <summary>
        ///     Constructor from list
        /// </summary>
        public TaskRepo(){
            TaskList = new List<TaskModel>();
        }

        /// <summary>
        ///     Variabile for task's ID 
        /// </summary>
        public int IdIncrementMethod(){
            return this.IdIncrement += 1;
        }

        /// <summary>
        /// 1. Method to get the list
        /// </summary>
        public IReadOnlyList<TaskModel> GetTaskList(){
            return TaskList.AsReadOnly();
        }

        /// <summary>
        /// 2. Method to add task in the list
        /// </summary>
         
        // @ Override
        public void AddTask(TaskModel model){
            this.TaskList.Add(model);
            Console.WriteLine("Task: " + model.TaskName + " was added");
        }

        /// <summary>
        /// 3. Method to delete method from the list
        /// </summary>
         
        // @ Override
        public void DeleteTask(TaskModel model){
            this.TaskList.Remove(model);
            Console.WriteLine("Task: " + model.TaskName + " was added");
        }
    }
}