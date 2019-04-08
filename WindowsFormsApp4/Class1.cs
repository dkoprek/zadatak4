using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Stoperica
    {
        public DateTimeOffset KlikStart;
        public DateTimeOffset KlikStop;
        public DateTimeOffset KlikLap;
        public int ProtekloVrijeme;
        public int RazlikaVremena;

        public Stoperica()
        {
            this.ProtekloVrijeme = 1;
            this.RazlikaVremena = 1;
        }
    }
}
