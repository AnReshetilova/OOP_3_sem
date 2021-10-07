using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    partial class Date
    {
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Date date = (Date)obj;

            if (date.Day == this.Day && date.Month == this.Month && date.Year == this.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"Year - {Year}, Month - {Month}, Day - {Day}";
        }
    }
}
