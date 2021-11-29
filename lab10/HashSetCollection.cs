using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab10
{
    class HashSetCollection<T>
    {
        private Node Tail;
        private Node Head;
        public int Length { get; private set; }

        class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }
        }

        public HashSetCollection()
        {
            Head = Tail = null;
            Length = 0;
        }

        public HashSetCollection(T element)
        {
            AddElement(element);
        }

        public void AddElement(T element)
        {
            if (!this.Contains(element))
            {
                Node node = new Node();
                node.Next = null;
                node.Element = element;

                if (Head == null)
                {
                    Head = Tail = node;
                    Length = 1;
                }
                else
                {
                    Tail.Next = node;
                    Tail = node;
                    Length++;
                }
            }
        }

        public void GetElements()
        {
            Node node = Head;

            while (node != null)
            {
                Console.WriteLine(node.Element.ToString());
                node = node.Next;
            }
        }
        public bool Contains(T element)
        {
            Node node = Head;

            for (int i = 0; i < Length; i++)
            {
                if (node.Element.Equals(element))
                {
                    return true;
                }
                node = node.Next;
            }

            return false;
        }
        public T GetElementByIndex(int index)
        {
            Node node = Head;

            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            return node.Element;
        }

        public void RemoveElementByIndex(int index)
        {
            Node node = Head;


            for (int i = 0; i < index - 1; i++)
            {
                node = node.Next;
            }

            node.Next = node.Next.Next;
            Length--;

        }
    }
}
