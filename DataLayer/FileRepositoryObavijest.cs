using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    class FileRepositoryObavijest : IObavijestRepository
    {
        private string _path = Settings.Default.ResourceDir + "Obavijesti.txt";

        public FileRepositoryObavijest() => CreateFileIfNonExistant();


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

        public ISet<Obavijest> GetObavijestiFromFile()
        {
            ISet<Obavijest> obavijesti = new HashSet<Obavijest>();
            string[] lines = File.ReadAllLines(_path);
            lines.ToList().ForEach(line => obavijesti.Add(Obavijest.ParseFromFileLine(line)));

            if (obavijesti.Count() == 0) { DataManager.ObavijestSetId(0); }
            else { DataManager.ObavijestSetId(obavijesti.Last().Id); }

            return obavijesti;
        }

        public void AddObavijest(Obavijest obavijest)
        {
            ISet<Obavijest> obavijesti = GetObavijestiFromFile();
            foreach(var o in obavijesti)
            {
                if (o.Equals(obavijest))
                {
                    Console.WriteLine("File Repo: OBAVIJEST POSTOJI");
                    return;
                }

            }

            obavijesti.Add(obavijest);
            File.WriteAllLines(_path, obavijesti.Select( o=> o.PrepareForFileLine()));
            DataManager.ObavijestIdAddOne();
            
        }


        public Obavijest GetObavijestById(int id) => GetObavijestiFromFile().FirstOrDefault(o => o.Id == id);
        public Obavijest GetObavijestByNazivAndKolegijId(string naziv, int kolegijId) => GetObavijestiFromFile().FirstOrDefault(o => o.Naziv == naziv && o.KolegijId == kolegijId);     

        public ISet<Obavijest> GetObavijestiByKolegijId(int id)
        {
            ISet<Obavijest> target = new HashSet<Obavijest>();

            foreach (Obavijest o in GetObavijestiFromFile())
            {
                if (o.KolegijId == id)
                {
                    target.Add(o);
                }

            }
            return target;
        
        }

        public ISet<Obavijest> GetObavijestiByKreatorId(int id)
        {
            ISet<Obavijest> target = new HashSet<Obavijest>();

            foreach (Obavijest o in GetObavijestiFromFile())
            {
                if (o.KreatorId == id)
                {
                    target.Add(o);
                }

            }
            return target;
        
        }

        public void UpdateObavijest(Obavijest obavijest)
        {
            ISet<Obavijest> obavijesti = GetObavijestiFromFile();
            ISet<Obavijest> obavijesti2 = new HashSet<Obavijest>();

            foreach (var o in obavijesti)
            {

                if (o.Id == obavijest.Id)
                {

                    obavijesti2.Add(obavijest);
                    Console.WriteLine("File Repo Obavijest Uspjesno Updatean");
                }
                else
                {
                    obavijesti2.Add(o);
                }
            }

            File.Delete(_path);
            File.Create(_path).Close();
            DataManager.ObavijestSetId(obavijesti2.Last().Id);

            obavijesti2.ToList().ForEach(AddObavijest);

        }



        public void DeleteObavijest(Obavijest obavijest)
        {

            ISet<Obavijest> obavijesti = GetObavijestiFromFile();
            ISet<Obavijest> obavijesti2 = new HashSet<Obavijest>();

            foreach (var o in obavijesti)
            {

                try
                {
                    if (!(o.Equals(obavijest)))
                    {

                        obavijesti2.Add(o);

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }

            File.Delete(_path);
            File.Create(_path).Close();
            DataManager.ObavijestSetId(obavijesti2.Last().Id);

            obavijesti2.ToList().ForEach(AddObavijest);

        }

    }

}
