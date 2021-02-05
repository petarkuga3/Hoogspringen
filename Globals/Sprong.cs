using System;
using System.Collections.Generic;
using System.Text;

namespace Globals
{
    public class Sprong : IComparable
    {
        public int Id { get; set; }

        public int Sprong_in_cm { get; set; }

        public Springer Springer { get; set; }

        public Sprong( int sprong_in_cm)
        {
            Sprong_in_cm = sprong_in_cm;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Sprong other = obj as Sprong;
            if (other != null)
                return this.Id.CompareTo(other.Id);
            else
                throw new ArgumentException("Object is not a Sprong");
        }
    }
}
