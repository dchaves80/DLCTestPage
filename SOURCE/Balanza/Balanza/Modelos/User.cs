using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanza.Modelos
{
    public class User
    {
        string nombre;
        int id;

        public string Nombre { get => nombre;}
        public int Id { get => id; }

        public User(int pid, string pnombre)
        {
            id = pid;
            nombre = pnombre;
        }

        
    }
}
