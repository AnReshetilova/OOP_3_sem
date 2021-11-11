using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Controllers
{
    partial class Port
    {
        private Node Tail;
        private Node Head;
        public int Length { get; private set; }

        class Node
        {
            public Vehicles.Ship Ship { get; set; }
            public Node Next { get; set; }
        }

        public Port()
        {
            Head = Tail = null;
            Length = 0;
        }

        public Port(Vehicles.Ship ship)
        {
            AddElement(ship);
        }

        public void AddElement(Vehicles.Ship ship)
        {
            Node node = new Node();
            node.Next = null;
            node.Ship = ship;

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


        public void GetShips()
        {
            Node node = Head;

            while (node != null)
            {
                Console.WriteLine(node.Ship.Name);
                node = node.Next;
            }
        }

        public Vehicles.Ship GetElementByIndex(int index)
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

                return node.Ship;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return null;
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
    }
}
