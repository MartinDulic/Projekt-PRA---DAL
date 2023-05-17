using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Administrator : Korisnik
    {

        private const char DEL = ':';
        public Administrator() { }
        public Administrator(string ime, string prezime, string email, string lozinka) : base(ime, prezime, email, lozinka)
        {
        }

        public override string ToString() => base.ToString();

        public override bool Equals(object obj) => obj is Administrator other ? Email.ToLower() == other.Email.ToLower() : false;
        public override int GetHashCode() => Id.GetHashCode();

        public string PrepareForFileLine() => $"{Id}{DEL}{Ime}{DEL}{Prezime}{DEL}{Email}{DEL}{Lozinka}";

        public static Administrator ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Administrator
            {
                Id=int.Parse(data[0]),
                Ime=data[1],
                Prezime=data[2],
                Email=data[3],
                Lozinka=data[4]
            };

        }

        


    }
}
