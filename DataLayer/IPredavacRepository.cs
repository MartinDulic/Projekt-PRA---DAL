using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPredavacRepository
    {
        //Vraca sve spremljene predavace
        ISet<Predavac> GetPredavaciFromFile();

        //Vraca predavaca preko ID Predavaca
        Predavac GetPredavacById(int id);

        //vraca predavaca koji predaje na kolegiju sa ID Kolegija
        Predavac GetPredavacByKolegijId(int id);

        //Vraca 1 Predavaca sa username i password
        Predavac GetPredavacByEmailAndPassword(string email, string password);

        //Dodaje 1 predavaca
        void AddPredavac(Predavac predavac);

        //Promijeni vrijednost prop prodavaca
        void UpdatePredavac(Predavac predavac);

        //Brise Predavaca
        void DeletePredavac(Predavac predavac);
    }
}
