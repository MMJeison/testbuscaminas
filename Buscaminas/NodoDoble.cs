using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class NodoDoble
    {
        public Celda celda { get; set; }
        public NodoDoble Li { get; set; }
        public NodoDoble Ld { get; set; }

        public NodoDoble(Celda celda)
        {
            Li = null;
            Ld = null;
            this.celda = celda;
        }
    }
}
