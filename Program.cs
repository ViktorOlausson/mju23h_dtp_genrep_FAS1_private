namespace mju23h_dtp_genrep_FAS1
{
    internal class Program
    {
        static List<Todo> todolist;
        class Todo
        {
            static public int waiting = 0, active = 1, done = 2, deleted = 3;
            DateTime start;
            string description;
            int status;
            public Todo(string description)
            {
                start = DateTime.Now;
                this.description = description;
                status = waiting;
            }
        }
        static void Main(string[] args)
        {
            // -2. Add a string method for the status
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