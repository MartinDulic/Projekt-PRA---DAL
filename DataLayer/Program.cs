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


            IAdminRepository adminRepository = Utilities.GetAdminRepository();
            IPredavacRepository predavacRepository = Utilities.GetPredavacRepository();
            IKolegijiRepository kolegijiRepository = Utilities.GetKolegijiRepository();
            IObavijestRepository obavijestRepository = Utilities.GetObavijestRepository();

        }
    }
}
