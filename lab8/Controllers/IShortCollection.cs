using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab5.People;
using lab5.Vehicles;

namespace lab8.Controllers
{
    interface IShortCollection<T> where T: notnull
    {
        void AddElement(T ship);
        void RemoveElementByIndex(int index);
        void GetElements();
    }
}
