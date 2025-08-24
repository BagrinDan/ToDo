using System;
using Classes;
using Interfaces;

namespace TODO{
    internal class Program{
        static void Main(string[] args){
            IToDoApplication _toDoApp = new ToDoApplication();
            _toDoApp.executeToDo();
        }
    }
}