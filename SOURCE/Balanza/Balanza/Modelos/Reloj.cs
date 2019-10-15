using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanza.Modelos
{
    public class Reloj
    {
        DateTime fechayhora;
        User usuario;

        public DateTime FechaYHora { get => fechayhora; }
        public User Usuario { get => usuario; }

        public Reloj(DateTime pfecha, User pusuario)
        {
            fechayhora = pfecha;
            usuario = pusuario;
        }
    }
}
