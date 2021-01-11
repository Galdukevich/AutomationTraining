using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class Node<T>
    {
        public T data { get; set; }
        public Node<T> Next { get; set; }
        public 
    }

    class MyList<T>
    {
        public Node<T> Head { get; set; }

        public MyList()
        {
            Head = null;
        }

        public void AddHead(T newNode)
        {
            Node<T> temp = Head;
            Head = new Node<T>(newNode);
            Head.Next = temp;

        }
    }
}
