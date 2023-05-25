using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataLayer
{
    class FileRepositoryPredavac : IPredavacRepository
    {
        private string _path = Settings.Default.ResourceDir + "Predavaci.txt";

        public FileRepositoryPredavac() => CreateFileIfNonExistant();


        public void CreateFileIfNonExistant()
        {
            try
            {
                if (!File.Exists(_path))
                {
                    File.Create(_path).Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        public ISet<Predavac> GetPredavaciFromFile()
        {
            ISet<Predavac> predavaci = new HashSet<Predavac>();
            string[] lines = File.ReadAllLines(_path);
            lines.ToList().ForEach(line => predavaci.Add(Predavac.ParseFromFileLine(line)));

            if (predavaci.Count() == 0) { DataManager.OsobaSetId(0); }
            else { DataManager.OsobaSetId(predavaci.Last().Id); }

            return predavaci;
        }
        public void AddPredavac(Predavac predavac)
        {

            ISet<Predavac> predavaci = GetPredavaciFromFile();
          
            foreach(var p in predavaci)
            {
                if (p.Equals(predavac))
                {
                    Console.WriteLine("File Repo: EMAIL ALLREADY IN USE");
                    return;
                }
            }

            predavaci.Add(predavac);
            File.WriteAllLines(_path, predavaci.Select(p => p.PrepareForFileLine()));
            DataManager.OsobaIdAddOne();
        }

        public Predavac GetPredavacById(int id) => GetPredavaciFromFile().FirstOrDefault(p => p.Id == id);
        public Predavac GetPredavacByEmailAndPassword(string email, string password) => GetPredavaciFromFile().FirstOrDefault(p => p.Email.ToLower() == email.ToLower() && p.Lozinka == password);

        public Predavac GetPredavacByKolegijId(int id)
        {
            Predavac target = new Predavac();
            foreach (Predavac p in GetPredavaciFromFile())
            {
                foreach (int i in p.KolegijiId)
                {
                    if (i == id)
                    {
                        target = p;
                        return target;
                    }

                }
            }

            return target;
        }


        public void UpdatePredavac(Predavac predavac)
        {
            ISet<Predavac> predavaci = GetPredavaciFromFile();
            ISet<Predavac> predavaci2 =new HashSet<Predavac>();


            foreach (var p in predavaci) {

                if (p.Id == predavac.Id)
                {

                    predavaci2.Add(predavac);
                    Console.WriteLine("File Repo Predavac Uspjesno Updatean");

                }
                else
                {
                    predavaci2.Add(p);
                }
            }

            File.Delete(_path);
            File.Create(_path).Close();
            DataManager.OsobaSetId(predavaci2.Last().Id);

            predavaci2.ToList().ForEach(AddPredavac);

        }



        public void DeletePredavac(Predavac predavac)
        {

            ISet<Predavac> predavaci = GetPredavaciFromFile();
            ISet<Predavac> predavaci2 = new HashSet<Predavac>();

            foreach (var p in predavaci)
            {
                try
                {

                    if (!(p.Equals(predavac)))
                    {

                        predavaci2.Add(p);

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                
            }

            File.Delete(_path);
            File.Create(_path).Close();
            DataManager.OsobaSetId(predavaci2.Last().Id);

            predavaci2.ToList().ForEach(AddPredavac);

        }

        public void UpdatePredavacZaKolegijId(int predavacId, int id)
        {
            // update predavac with predavacId to have kolegij with id
            ISet<Predavac> predavaci = GetPredavaciFromFile();

            foreach (var p in predavaci)
            {
                if (p.Id == predavacId)
                {
                    p.KolegijiId.Add(id);
                    UpdatePredavac(p);
                    return;
                }
            }
        }
    }
}
