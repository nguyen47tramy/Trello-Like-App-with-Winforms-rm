using System.Xml.Serialization;

namespace Trello
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            List<List> lists = new List<List>();
            Console.WriteLine("working!");

            Table.addTable(lists);
            Table.addTable(lists);

            Console.WriteLine("enter any key to continue!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("select list to add tasks");

            Console.WriteLine("add task?");
            bool choice = false;
            string temp = Console.ReadLine();

            if (temp.ToLower() == "yes")
            {
                choice = true;
            }

            while (choice == true)
            {
                //int temp;
                //temp = //mouse click
                lists.ElementAt(0).addTask();
                Console.WriteLine("more?");
                temp = Console.ReadLine();
                if (temp.ToLower() == "no")
                {
                    choice = false;
                }
            }

            lists.ElementAt(0).printTasks();

        }




    }
}