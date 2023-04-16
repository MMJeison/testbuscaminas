using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class MatEnListF1
    {
        private NodoDoble mat;

        public MatEnListF1(int filas, int columnas)
        {
            Celda cld = new Celda(filas, columnas, 0, new Size(0,0), null);
            mat = new NodoDoble(cld);
            mat.celda.valor = mat;
            this.contruyeNodosCabeza();
        }

        public int numFilas() { return mat.celda.fila; }
        public int numColumnas() { return mat.celda.columna; }
        public void contruyeNodosCabeza()
        {
            int m = numFilas();
            int n = numColumnas();
            int mayor = (m >= n) ? m : n;
            NodoDoble ultimo = mat;
            for (int i = 1; i <= mayor; i++)
            {
                Celda cld = new Celda(0, 0, mat, new Size(0,0), null);
                NodoDoble aux = new NodoDoble(cld);
                aux.Ld = aux;
                aux.Li = aux;
                ultimo.celda.valor = aux;
                ultimo = aux;
            }
        }
        public NodoDoble nodoCabeza() { return mat; }
        public NodoDoble primerNodo() { return (NodoDoble)mat.celda.valor; }
        public void conectaPorFilas(NodoDoble x)
        {
            int f = x.celda.fila;
            int c = x.celda.columna;
            if (f > this.numFilas() || f < 1 || c > this.numColumnas() || c < 1) { return; }
            NodoDoble p = primerNodo();
            for (int i = 1; i < f; i++) { p = (NodoDoble)p.celda.valor; }
            NodoDoble aq = p;
            NodoDoble q = p.Ld;
            while (q != p && c > q.celda.columna)
            {
                aq = q;
                q = q.Ld;
            }
            int cq = q.celda.columna;
            if (aq != q && q != p && c == cq)
            {
                //hay un dato almacenado en f,c
                q.celda = x.celda;
            }
            else
            {
                aq.Ld = x;
                x.Ld = q;
                int aux = p.celda.fila;
                p.celda.fila = aux + 1;
            }

        }
        public void conectaPorColumnas(NodoDoble x)
        {
            int f = x.celda.fila;
            int c = x.celda.columna;
            NodoDoble p = primerNodo();
            for (int i = 1; i < c; i++) { p = (NodoDoble)p.celda.valor; }
            NodoDoble aq = p;
            NodoDoble q = p.Li;
            while (q != p && f > q.celda.fila)
            {
                aq = q;
                q = q.Li;
            }
            int fq = q.celda.fila;
            if (aq != q && q != p && f == fq)
            {
                //ya hay un dato almacenado en f,c
                q.celda = x.celda;
            }
            else
            {
                aq.Li = x;
                x.Li = q;
                int aux = p.celda.columna;
                p.celda.columna = aux + 1;
            }
        }
        public void conectar(NodoDoble x)
        {
            this.conectaPorFilas(x);
            this.conectaPorColumnas(x);
        }
    }
}
