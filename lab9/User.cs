using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class User
    {
        public delegate void NewWindow();
        public event NewWindow Squeeze;
        public event NewWindow Replace;

        readonly int windowSize;
        readonly string windowPosition;
        public User(int size, string postion)
        {
            windowSize = size;
            windowPosition = postion;
        }

        public bool CheckPlace(int otherSize)
        {
            if (windowSize == otherSize)
            {
                Squeeze();
                return false;
            }

            return true;
        }

        public bool CheckPosition(string otherPosition)
        {
            if (windowPosition == otherPosition)
            {
                Replace();
                return false;
            }

            return true;
        }
    }
}
