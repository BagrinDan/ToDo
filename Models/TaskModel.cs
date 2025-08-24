using System;

namespace Models{
    public class TaskModel{
        public int TaskID {get; set; }
        public string? TaskName {get; set; }
        public bool IsCompleted {get; set; }
    }
}