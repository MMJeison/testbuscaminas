using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    class Celda
    {
        public int fila { get; set; }
        public int columna { get; set; }
        public Object valor { get; set; }
        public States estado { get; set; }
        public Image imagen { get; set; }
        public Size tamaño { get; set; }
        public Point ubicacion { get; set; }

        public Celda(int fila, int columna, Object valor, Size tamaño, Image imagen)
        {
            this.fila = fila;
            this.columna = columna;
            this.valor = valor;
            this.estado = States.Cubierta;
            this.tamaño = tamaño;
            this.imagen = imagen;
            this.ubicacion = new Point((columna - 1) * tamaño.Width, (fila - 1) * tamaño.Height);
        }
    }
    public enum States
    {
        Cubierta,
        Marcada,
        Descubierta
    }
}
