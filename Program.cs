namespace mju23h_dtp_genrep_FAS1
{
    internal class Program
    {
        static List<Todo> todolist;
        class Todo
        {
            DateTime start;
            string description;
            public Todo(string description)
            {
                start = DateTime.Now;
                this.description = description;
            }
        }
        static void Main(string[] args)
        {
            // -3. Add a status to the class
            // -2. Add a string method for the class
            // -1. Add a print method for the todo item
            //  1. Create a REPL with 'quit':
            //  2. Create dummy todo items
            //  3. Add 'list' that lists all active and waiting tasks
            //  4. Add 'list all' that lists all tasks
            //  5. Add 'new' that enables you to add new tasks
            //  6. ... continue here ...
        }
    }
}