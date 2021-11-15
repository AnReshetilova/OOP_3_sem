using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab8.Exceptions;
using System.IO;

namespace lab8.Controllers
{
    class Collection<T>: IShortCollection<T>
    {
        private Node Tail;
        private Node Head;
        public int Length { get; private set; }

        class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }
        }

        public Collection()
        {
            Head = Tail = null;
            Length = 0;
        }

        public Collection(T element)
        {
            AddElement(element);
        }

        public void AddElement(T element)
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


        public void GetElements()
        {
            Node node = Head;

            while (node != null)
            {
                Console.WriteLine(node.Element.ToString());
                node = node.Next;
            }
        }

        public T GetElementByIndex(int index)
        {
            Node node = Head;

            try
            {
                if (index < 0 || index >= Length)
                {
                    throw new ElementIndexOutOfRangeException();
                }

                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                return node.Element;
            }
            catch (ElementIndexOutOfRangeException e)
            {
                e.PrintMessage();
                return default(T);
            }
        }


        public void RemoveElementByIndex(int index)
        {
            Node node = Head;

            try
            {
                if (index < 0 || index >= Length)
                {
                    throw new ElementIndexOutOfRangeException();
                } 
            }
            catch (ElementIndexOutOfRangeException e)
            {
                 e.PrintMessage();
            }
            finally
            {
                for (int i = 0; i < index - 1; i++)
                {
                    node = node.Next;
                }

                node.Next = node.Next.Next;
                Length--;
            }
        }

        public void ToFile()
        {
            Node node = Head;
            
            using (StreamWriter sw = new StreamWriter(@"D:\вуз\3 сем\OOP_3_sem\lab8\out.txt", false, Encoding.Default))
            {
                while (node != null)
                {
                    sw.WriteLine(node.Element.ToString());
                    node = node.Next;
                }
            }
        }

        public Collection<string> FromFile()
        {
            Collection<string> collection = new Collection<string>();

            using (StreamReader sr = new StreamReader(@"D:\вуз\3 сем\OOP_3_sem\lab8\out.txt"))
            {
                string[] items = sr.ReadToEnd().Split('\n');
                foreach (var item in items)
                {
                    collection.AddElement(item);
                }
            }

            return collection;
        }
    }
}
