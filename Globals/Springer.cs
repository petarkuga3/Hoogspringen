using System;
using System.Collections.Generic;
using System.Text;

namespace Globals
{
    public enum Categorie { A = 'A', B = 'C', C = 'C', D = 'D', E = 'E'}

    public class Springer : IComparable
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public Categorie Categorie { get; set; }

        public ICollection<Sprong> Sprongen { get; set; }


        public Springer(string naam, Categorie category)
        {
            Naam = naam;
            Categorie = category;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Springer other = obj as Springer;
            if (other != null)
                return this.Naam.CompareTo(other.Naam);
            else
                throw new ArgumentException("Object is not a Springer");
        }
    }
}
