using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello
{
    internal class CardLinkedList
    {
        public Node First { get; set; } 
        public Node Last { get; set; }

        public int Count { get; set; }  

        //contructor
        public CardLinkedList() 
        {
            this.First = null;
            this.Last = null;
        }

        //add new node on the begining of the list
        public void AddFirst(Node newNode)
        {
            //if the linked list is empty, insert new node
            //the first and last poniter will be point to the new node
            if (this.First == null)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }

        //add node on the end of the list
        public void AddLast(Node newNode)
        {
            //check if the list is empty
            if (this.Last == null)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;

            }
            Count++;
        }

        public string toString()
        {
            return this.First.task;
        }

        public Node selectNode(int index)
        {
            int count = 1;
            Node current = this.First;

            while (count != index)
            {          
                current = current.Next;
                count++;
            }

            return current;
        }
        
    }
}
