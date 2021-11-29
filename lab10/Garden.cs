using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Garden : IList<Plant>
    {
        Plant[] contents = new Plant[10];
        public int Length { get; private set; }
        public Plant this[int index] {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value;
            }
        }

        public int Count => Length;

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Plant item)
        {
            if (Length + 1 < contents.Length)
            {
                Length++;
                contents[Length] = item;
            }
        }

        public void Clear()
        {
            Length = 0;
        }

        public bool Contains(Plant item)
        {
            foreach(Plant p in contents)
            {
                if(p == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Plant[] array, int arrayIndex)
        {
            for(int i = 0; i < contents.Length; i++)
            {
                array.SetValue(contents[i], arrayIndex++);
            }
        }

        public IEnumerator<Plant> GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(Plant item)
        {
            for(int i = 0; i < contents.Length; i++)
            {
                if(contents[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, Plant item)
        {
            contents[index] = item;
        }

        public bool Remove(Plant item)
        {
            RemoveAt(IndexOf(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    contents[i] = contents[i + 1];
                }
                Length--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
