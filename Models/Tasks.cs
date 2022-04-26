namespace Timesheets.Models
{
    public class Tasks
    {
        public readonly List<Task> item;

        public Tasks()
        {
            item = new List<Task>();
        }
    }

    public class Task 
    { 
        public int Id { get; set; }
        public string? Name { get; set; }

        public TimeSpan WorkLoad { get; set; }

        public int Performer { get; set; }
    }
}
