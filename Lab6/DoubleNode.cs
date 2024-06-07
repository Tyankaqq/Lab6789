using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class DoubleNode
    {
        public int Value;
        public DoubleNode Next;
        public DoubleNode Prev;

        public DoubleNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
