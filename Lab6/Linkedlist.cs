using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class CircularDoublyLinkedList
    {
        private DoubleNode head;
        private DoubleNode tail;

        public CircularDoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void Add(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                newNode.Next = head;
                head.Prev = newNode;
                tail = newNode;
            }
        }

        public void RemoveLastLessThan15()
        {
            if (head == null) return;

            DoubleNode current = tail;
            do
            {
                if (current.Value < 15)
                {
                    if (current == head && current == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;

                        if (current == head)
                        {
                            head = current.Next;
                        }

                        if (current == tail)
                        {
                            tail = current.Prev;
                        }
                    }
                    return;
                }
                current = current.Prev;
            } while (current != tail);
        }

        public void PrintList()
        {
            if (head == null) return;

            DoubleNode current = head;
            do
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            } while (current != head);
            Console.WriteLine();
        }
        public List<int> GetValues()
        {
            List<int> values = new List<int>();
            if (head == null) return values;

            DoubleNode current = head;
            do
            {
                values.Add(current.Value);
                current = current.Next;
            } while (current != head);

            return values;
        }
    }
}
