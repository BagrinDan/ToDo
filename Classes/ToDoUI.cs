using System;
using Interfaces;
using Options;

namespace Classes{
    /// <summary>
    /// This class is responding for UI part of TODO
    /// </summary>
    public class ToDoUI : IToDoUI{
        
        IToDoOptions _toDoOptions;
        ITaskRepo _taskRepo;
        IUserInput _userInput;
        
        public ToDoUI(IToDoOptions _toDoOptions){
            this._toDoOptions = _toDoOptions;
        }
                
        public void executeMenu(){

            int userInput = 0;

            do{
                // Print menu options
                PrintOptions();

                // User input for options
                userInput = menuInput();

                // Choose option via user input
                chooseOption(userInput);

                } while (userInput != 0);
        }

        /// <summary>
        /// Prints all options
        /// </summary>
        public void PrintOptions(){
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Create list");
            Console.WriteLine("2. Remove list");
            Console.WriteLine("3. Mark as complete");
            Console.WriteLine("4. Print all tasks");
            Console.WriteLine("5. Edit");
            Console.WriteLine("0. Exit");
        }

        /// <summary>
        /// Takes user input for options
        /// </summary>
        /// <param name="userInput"> Number of option. </param>
        public void chooseOption(int userInput){

            switch(userInput){
                case 1:
                    // CREATE
                    new CreateTask(_taskRepo, _userInput).executeOption();
                    break;
                case 2:
                    // REMOVE
                    break;
                case 3:
                    // MARK
                    break;
                case 4:
                    // PRINT
                    new PrintTasks(_taskRepo, _userInput).executeOption();
                    break;
                case 5:
                    // EDIT
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
                    
            }
        }

        /// <summary>
        /// Gets and validate user input
        /// </summary>1
        public int menuInput(){
            while(true){
                string? rawInput = Console.ReadLine();
                if(rawInput != null && int.TryParse(rawInput, out int userInput)){
                    return userInput;
                }
                    Console.WriteLine("Enter valid number");
            }   
        }
    }         
}
