using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.People
{
    sealed class Captain : IOwner
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public Captain(string name, int age)
        {
            Name = name;
            Age = age;
            Profession = "Captain";
        }

        public void BuySomething()
        {
            Console.WriteLine("Buy new ship");
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Captain captain = (Captain)obj;

            if (captain.Name != Name && captain.Age != Age)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
