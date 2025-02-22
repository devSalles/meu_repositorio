namespace TestandoDic
{
    class Program
    {
        //Dictionary public
        public static Dictionary<int,string> dic1 = new Dictionary<int, string>();
        //ID people 
        public static int ID;

        //Function to add people
        public static void ToAddPeople() 
        {
            Console.Clear();
            Console.WriteLine("How many people do you want to add: ");
            int.TryParse(Console.ReadLine(), out int people);

            for (int i = 0; i < people; i++)
            {
                Console.WriteLine("Type ID the people: ");
                int.TryParse(Console.ReadLine(), out ID);

                Console.WriteLine("Type name the people: ");
                string NamePeople=Console.ReadLine();

                if (!dic1.ContainsKey(ID))
                {
                    dic1.Add(ID, NamePeople);
                }
                else 
                {
                    i--;
                    Console.WriteLine("Don´t possible repeat the ID, try again ");
                }
            }
        }

        //Function to view Dictionary
        public static void ViewPeople() 
        {
            Console.Clear();
            foreach (var view in dic1)
            {
                Console.WriteLine($"{view.Key} - {view.Value}");
            }
        }

        //Function to remove people
        public static void RemovePeople() 
        {
            Console.Clear();
            Console.WriteLine("Type the ID for remove people");
            int.TryParse (Console.ReadLine(), out int removeID);

            if (removeID.Equals(ID)) 
            {
                dic1.Remove(ID);
                Console.WriteLine("ID removed with sucess");
            }
        }

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. To add people");
                Console.WriteLine("2.view list");
                Console.WriteLine("3.Remove People");
                Console.WriteLine("4.Out System");
                Console.WriteLine("Type your option: ");
                int.TryParse(Console.ReadLine(), out int op);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        ToAddPeople();
                    break;

                    case 2:
                        Console.Clear();
                        ViewPeople();
                    break;

                    case 3:
                        Console.Clear();
                        RemovePeople();
                    break;

                    case 4:
                        Console.Clear();
                        running = false;
                        Console.WriteLine("Out the system");
                    break;

                    default:
                        Console.Clear();
                        running =false;
                        Console.WriteLine("option incorret, type just between 1-3");
                    break;
                }

            }
        }
    }
}
