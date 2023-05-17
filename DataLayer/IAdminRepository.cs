using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IAdminRepository
    {

        //Vraca sve spremljene admine
        ISet<Administrator> GetAdminsFromFile();

        //Vraca 1 Admina sa username i password
        Administrator GetAdminByEmailAndPassword(string email, string password);

        //Dodaje 1 admina
        void AddAdmin(Administrator admin);



    }
}
