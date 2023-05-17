using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    class FileRepositoryKolegij : IKolegijiRepository
    {
        private const string PATH = @"Kolegiji.txt";

        public FileRepositoryKolegij() => CreateFileIfNonExistant();

        public void CreateFileIfNonExistant()
        {
            try
            {
                if (!File.Exists(PATH))
                {
                    File.Create(PATH).Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public ISet<Kolegij> GetKolegijiFromFile()
        {
            ISet<Kolegij> kolegiji = new HashSet<Kolegij>();
            string[] lines = File.ReadAllLines(PATH);
            lines.ToList().ForEach(line => kolegiji.Add(Kolegij.ParseFromFileLine(line)));

            if (kolegiji.Count() == 0) { Utilities.KolegijSetId(0); }
            else { Utilities.KolegijSetId(kolegiji.Last().Id); }

            return kolegiji;

        }


        public Kolegij GetKolegijById(int id) => GetKolegijiFromFile().FirstOrDefault(k => k.Id == id);
        public Kolegij GetKolegijByNaziv(string naziv) => GetKolegijiFromFile().FirstOrDefault(k => k.Naziv == naziv);

        public ISet<Kolegij> GetKolegijiByPredavacId(int id)
        {
            ISet<Kolegij> target = new HashSet<Kolegij>();

            foreach (Kolegij k in GetKolegijiFromFile())
            {
                if (k.PredavacId == id)
                {
                    target.Add(k);
                }

            }
            return target;
        }

        public void AddKolegij(Kolegij kolegij)
        {
            ISet<Kolegij> kolegiji = GetKolegijiFromFile();
            foreach (var k in kolegiji)
            {
                if (k.Equals(kolegij))
                {
                    Console.WriteLine("File Repo:KOLEGIJ ALLREADY EXISTS");
                    return;
                }
            }

            kolegiji.Add(kolegij);
            File.WriteAllLines(PATH, kolegiji.Select(k => k.PrepareForFileLine()));
            Utilities.KolegijIdAddOne();
        }


        public void UpdateKolegij(Kolegij kolegij)
        {
            ISet<Kolegij> kolegiji = GetKolegijiFromFile();
            ISet<Kolegij> kolegiji2 = new HashSet<Kolegij>();

            foreach (var k in kolegiji)
            {

                if (k.Id == kolegij.Id)
                {

                    kolegiji2.Add(kolegij);

                }
                else
                {
                    kolegiji2.Add(k);
                }
            }

            File.Delete(PATH);
            File.Create(PATH).Close();
            Utilities.KolegijSetId(kolegiji2.Last().Id);

            kolegiji2.ToList().ForEach(AddKolegij);

        }



        public void DeleteKolegij(Kolegij kolegij)
        {

            ISet<Kolegij> kolegiji = GetKolegijiFromFile();
            ISet<Kolegij> kolegiji2 = new HashSet<Kolegij>();

            foreach (var k in kolegiji)
            {

                try
                {
                    if (!(k.Equals(kolegij)))
                    {

                        kolegiji2.Add(k);

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }

            File.Delete(PATH);
            File.Create(PATH).Close();
            Utilities.KolegijSetId(kolegiji2.Last().Id);

            kolegiji2.ToList().ForEach(AddKolegij);

        }


    }
}
