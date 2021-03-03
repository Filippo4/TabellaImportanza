using System;
using System.Collections.Generic;
using System.Text;

namespace TabellaImportanza
{
    public class Riga
    {
        List<Cella> cella = new List<Cella>();
        public Cella CreaCella()
        {

            Cella c = new Cella();
            cella.Add(c);
            return c;
        }
    }
}
