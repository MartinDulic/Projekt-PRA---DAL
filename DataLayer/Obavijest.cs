using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Obavijest
    {


        private const char DEL = '|';

        private int counter = DataManager.ObavjestIdCounter;

        public int Id { get; set; }
        public int KolegijId { get; set; }
        public int KreatorId { get; set; }

        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumObjave { get; set; } = DateTime.Today;
        public DateTime DatumIsteka { get; set; }

        public Obavijest() { }
        public Obavijest(int kolegijId, int kreatorId, string naziv, string opis, DateTime datumObjave, DateTime datumIsteka)
        {
            Id = counter;
            KolegijId = kolegijId;
            KreatorId = kreatorId;
            Naziv = naziv;
            Opis = opis;
            DatumObjave = datumObjave;
            DatumIsteka = datumIsteka;

        }

        public override string ToString() => $"Id: {Id}, KolegijId: {KolegijId}, KreatorId: {KreatorId}, Naziv: {Naziv}, Opis: {Opis}, Datum Objave: {DatumObjave}, Datum Isteka: {DatumIsteka}";
        public override int GetHashCode() => Id.GetHashCode();
        public override bool Equals(object obj) => obj is Obavijest other ? KolegijId==other.KolegijId && Naziv==other.Naziv : false;


        public string PrepareForFileLine() => $"{Id}{DEL}{KolegijId}{DEL}{KreatorId}{DEL}{Naziv}{DEL}{Opis}{DEL}{DatumObjave}{DEL}{DatumIsteka}";

        public static Obavijest ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);

            return new Obavijest
            {
                Id=int.Parse(data[0]),
                KolegijId=int.Parse(data[1]),
                KreatorId=int.Parse(data[2]),
                Naziv=data[3],
                Opis=data[4],
                DatumObjave=DateTime.Parse(data[5]),
                DatumIsteka=DateTime.Parse(data[6])

            };

        }



    }
}
