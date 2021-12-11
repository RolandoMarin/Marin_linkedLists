using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marin_linkedLists
{
    class LinkedList
    {
        public Node Add(Node head, Node newNode)
        {
            if (head == null)
                return newNode;


            Node current = head;

            while (current != null)
            {
                if (current.Next == null)
                {
                    current = newNode;
                    return head;

                }
                else
                    current = current.Next;

            };
            return head;

        }

        public Node Contains(Node head, string item)
        {
            if (head == null)
                return null;
            Node current = head;

            while (current != null)
            {
                if (current.Data.ToLower() == item.ToLower())
                    return current;
                else
                    current = current.Next;

            };
            return null;
        }
        public Node Remove(Node head, string item)
        {
            if (head.Data.ToLower() == item.ToLower() && head.Next == null)
            {
                head = null;
                return head;

            }
            else if (head.Data.ToLower() == item.ToLower())
            {
                head = head.Next;
                return head;
            }
            Node current = head;

            while (current.Next != null)
            {
                if (current.Next.Data.ToLower() == item.ToLower() && current.Next.Next == null)
                {
                    current.Next = null;
                    return head;
                }
                else if (current.Next.Data.ToLower() == item.ToLower())
                {
                    current.Next = current.Next.Next;
                    return head;
                }
                else
                    current = current.Next;
            };
            return head;

        }

        public string PrintNodes(Node head)
        {
            
            Node current = head;
            string allNode = "- " + current.Data;

            while (current.Next != null)
            {
                current = current.Next;
                allNode += $"\n- {current.Data}";
            };
            return allNode;
        }


    }
}
