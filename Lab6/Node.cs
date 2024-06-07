using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Node
    {
        public double Value;
        public Node Next;

        public Node(double value)
        {
            Value = value;
            Next = null;
        }
    }
}
