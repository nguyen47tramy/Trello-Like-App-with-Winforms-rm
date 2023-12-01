using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trello
{
    internal class Table
    {
        
        public static void addTable(List<List> lists)
        {
            Console.WriteLine("pls input name:");
            string name = Console.ReadLine();
            LinkedList<string> tasks = new LinkedList<string>();
            lists.Add(new List(name, tasks));
            Console.WriteLine("Added!");
        }

        public static void select(List<List> lists)
        {

        }
    }
}
