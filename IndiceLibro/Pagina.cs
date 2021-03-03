using System;
using System.Collections.Generic;
using System.Text;

namespace IndiceLibro
{
    class Pagina
    {
        private string t = "";
        public Pagina(string t)
        {
            this.t = t;
        }

        public string ToString3()
        {
            return t ;
        }
    }
}
