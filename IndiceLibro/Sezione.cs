using System;
using System.Collections.Generic;
using System.Text;

namespace IndiceLibro
{
    class Sezione
    {
        List<Sezione> Sez = new List<Sezione>();
        List<Pagina> Pag = new List<Pagina>();
        public Sezione() { }

        public string ToString2()
        {
            string testo = "Stampo la sezione...";
            foreach (Sezione s in Sez)
            {
                foreach (Pagina p in s.Pag)
                    testo += p.ToString3();
            }
            foreach (Pagina p in Pag)
                p.ToString3();
            return testo;
        }
    }
}
