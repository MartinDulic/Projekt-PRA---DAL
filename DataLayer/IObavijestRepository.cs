using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IObavijestRepository
    {   
        //Vraca spremljene obavijesti
        ISet<Obavijest> GetObavijestiFromFile();

        //Vraca obavijest preko Id Obavijest
        Obavijest GetObavijestById(int id);

        //Vraca 1 Obavijest Preko Naziv i Id Kolegija obavijesti
        Obavijest GetObavijestByNazivAndKolegijId(string naziv,int kolegijId);

        //Vraca sve obavijesti vezane uz kolegij preko ID kolegija
        ISet<Obavijest> GetObavijestiByKolegijId(int id);

        //Vraca sve obavijesti vezane uz kreatora preko ID kreatora
        ISet<Obavijest> GetObavijestiByKreatorId(int id);

        //Dodaje 1 obavijest
        void AddObavijest(Obavijest obavijest);

        //Mijena vrijednost prop Obavijesti(osim Id)
        void UpdateObavijest(Obavijest obavijest);

        //Brise obavijest
        void DeleteObavijest(Obavijest obavijest);
    }
}
