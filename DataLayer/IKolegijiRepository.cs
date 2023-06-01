using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IKolegijiRepository
    {

        //Vraca sve spremljene kolegije
        ISet<Kolegij> GetKolegijiFromFile();

        //Vraca kolegij preko Id Kolegija
        Kolegij GetKolegijById(int id);

        //Vraca 1 kolegij preko naziva kolegija
        Kolegij GetKolegijByNaziv(string naziv);
        //Vraca sve kolegije od 1 predavaca preko ID Prodavac
        ISet<Kolegij> GetKolegijiByPredavacId(int id);

        //Dodaje 1 Kolegiji
        void AddKolegij(Kolegij kolegij);

        //Minjenja prop kolegija osim ID
        void UpdateKolegij(Kolegij kolegij);

        //Brise Kolegij
        void DeleteKolegij(Kolegij kolegij);

        // Update Kolegij za PredavacId
        void UpdateKolegijZaPredavacId(int crsID, int id);
    }
}
