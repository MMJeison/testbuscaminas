using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Buscaminas : Form
    {
        Label aux;
        Label seleccion;
        public Buscaminas()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            aux = null;
            seleccion = null;
            numFilas.Maximum = 30;
            numFilas.Minimum = 3;
            numColumnas.Maximum = 60;
            numColumnas.Minimum = 3;
            numFilas.Value = 10;
            numColumnas.Value = 20;
            numMinas.Value = 30;
            lbl_filas.Enabled = false;
            lbl_columnas.Enabled = false;
            lbl_minas.Enabled = false;
            numFilas.Enabled = false;
            numColumnas.Enabled = false;
            numMinas.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int filas = 1, columnas = 1, minas = 0;
            if (seleccion == lbl_principiante)
            {
                filas = 8;
                columnas = 8;
                minas = 10;
            }
            else if (seleccion == lbl_intermedio)
            {
                filas = 16;
                columnas = 16;
                minas = 40;
            }
            else if (seleccion == lbl_experto)
            {
                filas = 16;
                columnas = 30;
                minas = 99;
            }
            else
            {
                filas = (int)numFilas.Value;
                columnas = (int)numColumnas.Value;
                minas = (int)numMinas.Value;
            }
            Game game = new Game(filas, columnas, minas);
            this.Visible = false;
            game.ShowDialog();
            this.Visible = true;
        }
        private void numFilas_ValueChanged(object sender, EventArgs e)
        {
            actualizarMaximasMinas();
        }
        private void numColumnas_ValueChanged(object sender, EventArgs e)
        {
            actualizarMaximasMinas();
        }
        private void actualizarMaximasMinas()
        {
            numMinas.Maximum = numFilas.Value * numColumnas.Value;
        }
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (seleccion != null) seleccion.BackColor = Color.Transparent;
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Gray;
            seleccion = lbl;
            if (seleccion == lbl_personalizado)
            {
                lbl_filas.Enabled = true;
                lbl_columnas.Enabled = true;
                lbl_minas.Enabled = true;
                numFilas.Enabled = true;
                numColumnas.Enabled = true;
                numMinas.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                lbl_filas.Enabled = false;
                lbl_columnas.Enabled = false;
                lbl_minas.Enabled = false;
                numFilas.Enabled = false;
                numColumnas.Enabled = false;
                numMinas.Enabled = false;
                button1.Enabled = false;
            }
            if (button1.Enabled == false) button1.Enabled = true;
        }
        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl == seleccion) return;
            lbl.BackColor = Color.LightGray;
            aux = lbl;
        }
        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            if (aux != null && aux != seleccion) aux.BackColor = Color.Transparent;
        }
    }
}
