using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DataManager
    {
        private static readonly IPredavacRepository PREDAVAC_REPO= new FileRepositoryPredavac();
        private static readonly IAdminRepository ADMIN_REPO= new FileRepositoryAdmin();
        private static readonly IKolegijiRepository KOLEGIJ_REPO= new FileRepositoryKolegij();
        private static readonly IObavijestRepository OBAVJEST_REPO= new FileRepositoryObavijest();


        //Vraca Admin File Repository
        public static IAdminRepository GetAdminRepository() => ADMIN_REPO;

        //Vraca Predavac File Repository
        public static IPredavacRepository GetPredavacRepository() => PREDAVAC_REPO;

        //Vraca Kolegij File Repository
        public static IKolegijiRepository GetKolegijiRepository() => KOLEGIJ_REPO;

        //Vraca Admin Repository    !!! NAPOMENA: ovaj repository se po specifikaciji uopce ne koristi unutar GUI-a 
        public static IObavijestRepository GetObavijestRepository() => OBAVJEST_REPO;


        //Vraca true ako korisnik postoji u FileRepositoryu 
        public static bool IsValidUser(string email,string password)
        {
            IAdminRepository adminRepository = GetAdminRepository();
            IPredavacRepository predavacRepository = GetPredavacRepository();

            return adminRepository.GetAdminByEmailAndPassword(email, password) != null || 
                   predavacRepository.GetPredavacByEmailAndPassword(email, password) != null;
        }


        //Vraca true ako je neki korisnik admin false inace
        public static bool IsAdmin(Korisnik k) => k is Administrator;









        //sve metode ispod se koriste u metodama klasa koje se spremaju pomocu FileRepository-a i nisu tu da bi se pozivale izvan DataLayera   


        public static int OsobaIdcounter = PREDAVAC_REPO.GetPredavaciFromFile().Count() + ADMIN_REPO.GetAdminsFromFile().Count();

        public static void OsobaIdAddOne()
        {
            ++OsobaIdcounter;

        }

        public static void OsobaSetId(int id)
        {
            OsobaIdcounter = id +1;
        }

        public static int KolegijIdCounter = KOLEGIJ_REPO.GetKolegijiFromFile().Count()+1;

        public static void KolegijIdAddOne()
        {
            ++KolegijIdCounter;
        }

        public static void KolegijSetId(int id)
        {
            KolegijIdCounter = id + 1;
        }

        public static int ObavjestIdCounter = OBAVJEST_REPO.GetObavijestiFromFile().Count() + 1;

        public static void ObavijestIdAddOne()
        {
            ++ObavjestIdCounter;
        }

        public static void ObavijestSetId(int id)
        {
            ObavjestIdCounter = id + 1;
        }




    }
}
