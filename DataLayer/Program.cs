using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {


            IAdminRepository adminRepository = DataManager.GetAdminRepository();
            IPredavacRepository predavacRepository = DataManager.GetPredavacRepository();
            IKolegijiRepository kolegijiRepository = DataManager.GetKolegijiRepository();
            IObavijestRepository obavijestRepository = DataManager.GetObavijestRepository();

        }
    }
}
