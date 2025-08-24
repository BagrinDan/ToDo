using System;
using Interfaces;


namespace Input{
    public class UserInput : IUserInput{


        public string userInput(){
            string? userInput;
            bool check;

            do{
                Console.WriteLine("Introduce task name:");
                userInput = Console.ReadLine();
                check = validateUserInput(userInput);
            } while(check == false);            

            return userInput;
        }

        // !!!
        public bool validateUserInput(string? userInput){
            if(userInput == null){
                return false;
            } else {
                return true;
            }
        }
    }
}