using System;
using System.Collections.Generic;

namespace TabellaImportanza
{
    public class Tabella
    {
        List<Riga> riga = new List<Riga>();

        public Riga CreaRiga()
        {
            Riga r = new Riga();
            riga.Add(r);
            return r;
        }
    }
}
