using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Kolegij
    {
        private const char DEL = '%';
        private int counter = DataManager.KolegijIdCounter;

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Ects { get; set; }
        public int PredavacId { get; set; }



        public Kolegij(string naziv,int ects,int predavacId)
        {
            Id = counter;
            Naziv = naziv;
            Ects = ects;
            PredavacId = predavacId;

        }
        public Kolegij() { }



        public override bool Equals(object obj) => obj is Kolegij other ? Naziv==other.Naziv  : false;
        public override int GetHashCode() => Id.GetHashCode();
        public override string ToString() => $"Kolegij Id: {Id}, Naziv: {Naziv}, ECTS: {Ects}, Predavac Id: {PredavacId} ";
    


        public string PrepareForFileLine()=> $"{Id}{DEL}{Naziv}{DEL}{Ects}{DEL}{PredavacId}";

        public static Kolegij ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);

            return new Kolegij
            {
                Id=int.Parse(data[0]),
                Naziv=data[1],
                Ects=int.Parse(data[2]),
                PredavacId=int.Parse(data[3])

            };


        }



    }
}
