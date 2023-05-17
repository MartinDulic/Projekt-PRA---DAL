using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Korisnik : Osoba
    {
        public string Lozinka { get; set; }

        public Korisnik(string ime, string prezime, string email,string lozinka) : base(ime, prezime, email)
        {

            Lozinka = lozinka;

        }
        public Korisnik() { }

        public override string ToString() => base.ToString() + $" Lozinka: {Lozinka}";
        public override bool Equals(object obj) => obj is Korisnik other ? Id == other.Id : false;
        public override int GetHashCode() => Id.GetHashCode();

    }
}
