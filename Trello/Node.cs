using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello
{
    internal class Node
    {
        public string task { get; set; }
        public Node Next { get; set; }


        public Node()
        {
            task = null;
            Next = null;
        }

        public Node(string task)
        {
            this.task = task;
            Next = null;
        }


    }
}
