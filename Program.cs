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
            public string Status()
            {
                if (status == 0) return "waiting";
                else if (status == 1) return "active";
                else if (status == 2) return "done";
                else if (status == 3) return "deleted";
                else return "(invalid status)";
            }
            public void Print()
            {
                Console.WriteLine($"{start,-10} {Status(),-9} {description,-40}");
            }
        }
        static void Main(string[] args)
        {
            //  2. Create dummy todo items
            todolist = new List<Todo>();
            todolist.Add(new Todo("Köpa cola"));
            todolist.Add(new Todo("Köpa julmust"));
            todolist.Add(new Todo("Betala räkningar"));

            string commando = "";
            do
            {
                Console.Write("> ");
                commando = Console.ReadLine().ToLower();

                if (commando == "help")
                {
                    Console.WriteLine("NYI: \n här kommer alla kommandona visas"); //NYI: help kommando: skriva ut alla kommandon som finns i programmet
                }
                else if (commando == "list")
                {
                    Console.WriteLine("NYI: här kommer alla todo item som är waiting or active visas"); //NYI: här kommer alla todo item som är waiting or active visas
                }

            } while (commando != "quit");



            //  3. Add 'list' that lists all active and waiting tasks
            //  4. Add 'list all' that lists all tasks
            //  5. Add 'new' that enables you to add new tasks
            //  6. ... continue here ...
        }
    }
}