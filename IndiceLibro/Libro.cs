using System;

namespace IndiceLibro
{
    public class Libro
    {

        public List<Pagina> Pag { get; private set; } = new List<Pagina>();
        List<Sezione> Sez = new List<Sezione>();

        public Libro() { }

        public string ToString1()
        {
            string testo = "Stampo il libro...";
            foreach (Pagina p in Pag)
                testo += p.ToString();

            return testo;
        }

        public Sezione AddSezione(Sezione s)
        {
            Sez.Add(s);
            return s;
        }

        public Pagina AddPagina(string testo)
        {
            Pagina p = new Pagina(testo);
            Pag.Add(p);
            return p;
        }
    }
}
}
