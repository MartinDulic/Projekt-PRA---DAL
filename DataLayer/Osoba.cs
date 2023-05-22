using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class Osoba
    {
        private int counter = DataManager.OsobaIdcounter;

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

        public Osoba(string ime,string prezime,string email)
        {
            Id = counter;
            Ime = ime;
            Prezime = prezime;
            Email = email;

        }
        public Osoba() { }


        public override string ToString() => $"Id: {Id} Ime: {Ime} Prezime: {Prezime} Email: {Email}";
        public override bool Equals(object obj) => obj is Osoba other ? Email.ToLower() == other.Email.ToLower() : false;
        public override int GetHashCode() => Id.GetHashCode();

    }
}
