using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Q
    {
        private Node head;
        private Node tail;

        public Q()
        {
            head = null;
            tail = null;
        }

 
        public void Enqueue(double value)
        {
            Node newNode = new Node(value);
            if (tail != null)
            {
                tail.Next = newNode;
            }
            tail = newNode;
            if (head == null)
            {
                head = newNode;
            }
        }


        public double Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            double value = head.Value;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            return value;
        }


        public bool IsEmpty()
        {
            return head == null;
        }

  
        public void PrintQueue()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

  
        public double SumNegativeElements()
        {
            double sum = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Value < 0)
                {
                    sum += current.Value;
                }
                current = current.Next;
            }
            return sum;
        }
        public List<double> GetQueueValues()
        {
            List<double> values = new List<double>();
            Node current = head;
            while (current != null)
            {
                values.Add(current.Value);
                current = current.Next;
            }
            return values;
        }
    }
}
