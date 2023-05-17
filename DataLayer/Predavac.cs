using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Predavac : Korisnik
    {

        private const char DEL = '#';
        private const char ID_DEL = '&';

        public ISet<int> KolegijiId { get; set; }

        public Predavac(string ime, string prezime, string email, string lozinka, ISet<int> kolegijiId) : base(ime, prezime, email, lozinka)
        {

            KolegijiId = kolegijiId;
            
        }

        public Predavac() { }

        public override string ToString() => base.ToString() + $" Kolegiji: {KolegijiId}";   
        public override bool Equals(object obj) => obj is Predavac other ? Email.ToLower()==other.Email.ToLower(): false;
        public override int GetHashCode() => Id.GetHashCode();






        public string PrepareForFileLine()
        {

            string kolegijiId = "";

            foreach(int i in KolegijiId)
            {
                kolegijiId += i;
                kolegijiId += ID_DEL;
            }


            return $"{Id}{DEL}{Ime}{DEL}{Prezime}{DEL}{Email}{DEL}{Lozinka}{DEL}{kolegijiId}";

        }

        public static Predavac ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);

            string[] kolegijiIdLine = data[5].Split(ID_DEL);

            ISet<int> kolegijiId = new HashSet<int>();

            foreach(string s in kolegijiIdLine)
            {

                if (s == "")
                {
                    break;
                }
                
                try
                {
                    kolegijiId.Add(int.Parse(s));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message +"AJDE");
                   
                }
            }

            return new Predavac
            {
                Id = int.Parse(data[0]),
                Ime = data[1],
                Prezime = data[2],
                Email = data[3],
                Lozinka = data[4],
                KolegijiId = kolegijiId
            };

        }

    }
}
