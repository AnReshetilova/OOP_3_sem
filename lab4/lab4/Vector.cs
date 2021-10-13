using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Vector
    {
        private Node Tail;
        private Node Head;
        public int Length { get; private set; }

        public static readonly (int id, string name, string organisation) Owner = (12312414, "AnResh", "BSTU");
        public static class Date
        {
            public static readonly string creationDate = "10.13.2021";
        }
        class Node
        {
            public int Info { get; set; }
            public Node Next { get; set; }
        }

        public Vector()
        {
            Head = Tail = null;
            Length = 0;
        }

        public Vector(int info)
        {
            AddElement(info);
        }

        public void AddElement(int info)
        {
            Node node = new Node();
            node.Next = null;
            node.Info = info;

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


        public void GetVector()
        {
            Node node = Head;

            while (node != null)
            {
                Console.Write(node.Info + " ");
                node = node.Next;
            }

            Console.WriteLine();
        }

        public int GetElementByIndex(int index)
        {
            Node node = Head;

            try
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                return node.Info;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }


        public void RemoveElementByIndex(int index)
        {
            Node node = Head;

            try
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                for (int i = 0; i < index - 1; i++)
                {
                    node = node.Next;
                }

                node.Next = node.Next.Next;
                Length--;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            v1.Tail.Next = v2.Head;
            return v1;
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            if(v1.Length > v2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            if (v1.Length < v2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator true(Vector v1)
        {
            if (v1.Head == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator false(Vector v1)
        {
            if (v1.Head != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vector operator ==(Vector v1, Vector v)
        {
            for(int i = 0; i < v.Length; i++)
            {
                v1.AddElement(v.GetElementByIndex(i));
            }
            return v1;
        }

        public static Vector operator !=(Vector v1, Vector v)
        {
            return null;
        }
    }
}
