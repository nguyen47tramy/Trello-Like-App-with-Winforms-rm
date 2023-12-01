using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trello
{
    internal class List
    {
        private string name;
        private LinkedList<string> tasks;

        public List(string name, LinkedList<string> tasks)
        {
            this.name = name;
            this.tasks = tasks;
        }

        public void addTask()
        {
            Console.WriteLine("pls input a task:");
            string t = Console.ReadLine();
            this.tasks.AddLast(t);
            Console.WriteLine("tasks added!");

        }

        public void printTasks()
        {
            Console.WriteLine("Tasks list: ");
            foreach (string task in this.tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
