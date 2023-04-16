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
    public partial class Game : Form
    {
        //Obejetos
        private Size tamCelda;
        private int filas, columnas, numMinas, banderas;
        private MatEnListF1 tablero;
        private int celdasSinMina, celdasDescubiertas;
        private List<int[]> posicionesDisponibles; //
        private bool IsPlaying;

        public Game(int filas, int columnas, int minas)
        {
            InitializeComponent();
            //le asigno algunas propiedades al form
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //
            this.filas = filas;
            this.columnas = columnas;
            numMinas = minas;
            tamCelda = new Size(20, 20);
            //le asignamos nuevos tamaños a los elementos del form para que se adapten al tamaño del tablero
            if (columnas >= 10)
            {
                Canvas.Size = new Size(columnas * tamCelda.Width + 5, filas * tamCelda.Height + 5);
                Size = new Size(Canvas.Size.Width + 35, Canvas.Size.Height + 105);
                panel2.Size = new Size(Canvas.Size.Width, panel2.Size.Height);
                panel3.Size = new Size(Canvas.Size.Width, panel3.Size.Height);
                label3.Location = new Point(lbl_Banderas.Location.X - label3.Size.Width, label3.Location.Y);
            }
            else
            {
                int aux = 10 - columnas;
                aux = aux * tamCelda.Width;
                Canvas.Size = new Size(columnas * tamCelda.Width + 5, filas * tamCelda.Height + 5);
                this.Size = new Size(this.Size.Height, Canvas.Size.Height + 105);
                Canvas.Location = new Point(Canvas.Location.X + (aux / 2), Canvas.Location.Y);
            }
            //
            lbl_Minas.Text = minas.ToString();
            celdasSinMina = (filas * columnas) - numMinas;
            this.CenterToScreen();
            //se inicia un nuevo juego
            iniciarJuego();
            //
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            NodoDoble cab, p, q;
            Celda cld;
            cab = tablero.nodoCabeza();
            p = tablero.primerNodo();
            Graphics g = e.Graphics;
            Point ubc;
            Image bloque = (Bitmap)Properties.Resources.Block;
            Image bandera = (Bitmap)Properties.Resources.Flag;
            while (p != cab)
            {
                q = p.Ld;
                while (q != p)
                {
                    cld = q.celda;
                    ubc = cld.ubicacion;
                    if (cld.estado == States.Cubierta)
                    {
                        g.DrawImage(bloque, ubc.X, ubc.Y, tamCelda.Width, tamCelda.Height);
                    }
                    else if (cld.estado == States.Marcada)
                    {
                        g.DrawImage(bandera, ubc.X, ubc.Y, tamCelda.Width, tamCelda.Height);
                    }
                    else
                    {
                        g.DrawImage(cld.imagen, ubc.X, ubc.Y, tamCelda.Width, tamCelda.Height);
                    }
                    q = q.Ld;
                }
                p = (NodoDoble)p.celda.valor;
            }
        }
        private void iniciarJuego()
        {
            crearTablero();//se crea un nuevo tablero con casiilas vacias
            insertarMinas(); //se insertan las minas en el tablero
            celdasDescubiertas = 0;
            banderas = 0;
            lbl_Banderas.Text = banderas.ToString();
            btn_Reiniciar.Text = "Reiniciar Juego";
            btn_Reiniciar.Enabled = false; //evita que se reinicie el juego si aun no se ha dado el primer click
            IsPlaying = true;
        }
        private void crearTablero()
        {
            tablero = new MatEnListF1(filas, columnas); // se cre crea un nuevo tablero vacio
            posicionesDisponibles = new List<int[]>(); //se crea una nueva lista que nos facilitará el insertar las minas
            int[] pos;
            NodoDoble aux;
            Celda cld;
            Image img = (Bitmap)Properties.Resources.Number_0;
            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= columnas; j++)
                {
                    cld = new Celda(i, j, 0, tamCelda, img); //se crea la casilla  vacia
                    aux = new NodoDoble(cld);
                    tablero.conectar(aux); //se almacenar la casilla
                    pos = new int[]{i,j};
                    posicionesDisponibles.Add(pos);//se almacena la posicion
                }
            }
        }
        private void insertarMinas()
        {
            int n = 0;
            Random r = new Random();
            int m, f, c;
            int[] pos;
            NodoDoble p;
            Celda cld;
            while (n < numMinas)
            {
                m = r.Next(0, posicionesDisponibles.Count); //se selecciona un numero al azar entre 0 y el numero de posiciones disponibles
                pos = posicionesDisponibles.ElementAt(m); 
                posicionesDisponibles.RemoveAt(m); //se remueve la posicion seleccionada
                f = pos[0];
                c = pos[1];
                p = tablero.primerNodo();
                for (int i = 1; i < f; i++) { p = (NodoDoble)p.celda.valor; }
                p = p.Ld;
                for (int i = 1; i < c; i++) { p = p.Ld; }
                cld = p.celda;
                cld.valor = 9; //se lasigna valor 9 a la casilla en la posicion seleccionada lo que indica que contiene una mina
                actualizarImagen(cld); // se actualiza la imagen de dicha casilla
                aumentarValorVecinas(cld.fila, cld.columna); //aumenta el valor de las casilla vecinas
                n += 1;
            }
        }
        private void aumentarValorVecinas(int f, int c)
        {
            NodoDoble p;
            Celda cld;
            //se verifica cada una de las celdas vecinas a la posicion f,c
            for (int i = f - 1; i <= f + 1; i++)
            {
                if (i < 1 || i > filas) continue; 
                for (int j = c - 1; j <= c + 1; j++)
                {
                    if (i == f && j == c) continue;
                    if (j < 1 || j > columnas) continue;
                    p = tablero.primerNodo();
                    for (int k = 1; k < i; k++) p = (NodoDoble)p.celda.valor;
                    p = p.Ld;
                    for (int k = 1; k < j; k++) p = p.Ld;
                    cld = p.celda;
                    if ((int)cld.valor != 9)
                    {
                        //si la celda no es una mina se aumenta su valor y se actualiza su imn¿gen
                        int aux = (int)cld.valor;
                        cld.valor = aux + 1;
                        actualizarImagen(cld);
                    }
                }
            }
        }
        private void actualizarImagen(Celda cld)
        {
            //se le asigna la imagen correspondiente a la celda
            cld.imagen =
                (int)cld.valor == 9 ? (Bitmap)Properties.Resources.Mine :
                (int)cld.valor == 0 ? (Bitmap)Properties.Resources.Number_0 :
                (int)cld.valor == 1 ? (Bitmap)Properties.Resources.Number_1 :
                (int)cld.valor == 2 ? (Bitmap)Properties.Resources.Number_2 :
                (int)cld.valor == 3 ? (Bitmap)Properties.Resources.Number_3 :
                (int)cld.valor == 4 ? (Bitmap)Properties.Resources.Number_4 :
                (int)cld.valor == 5 ? (Bitmap)Properties.Resources.Number_5 :
                (int)cld.valor == 6 ? (Bitmap)Properties.Resources.Number_6 :
                (int)cld.valor == 7 ? (Bitmap)Properties.Resources.Number_7 :
                (Bitmap)Properties.Resources.Number_8;
        }
        private void descubrir(Celda cld)
        {
            cld.estado = States.Descubierta; //actualiza el estado de la celda
            celdasDescubiertas += 1; // aumenta el numero de celdas decubiertas
        }
        private void marcar(Celda cld)
        {
            cld.estado = States.Marcada; //actualiza el estado de las celda
            banderas += 1; //aumenta el contador de banderas
            lbl_Banderas.Text = banderas.ToString(); //actualiza el label que muestra el numero de celdas marcadas
            if (banderas > numMinas) lbl_Banderas.ForeColor = Color.Red;
        }
        private void desmarcar(Celda cld)
        {
            cld.estado = States.Cubierta; //actualiza el estado de la celda
            banderas -= 1; //disminuye el contador de banderas
            lbl_Banderas.Text = banderas.ToString();//actualiza el label que muestra el numero de celdas marcadas
            if (banderas <= numMinas) lbl_Banderas.ForeColor = Color.Black;
        }
        private void clickIzquierdo(int f, int c)
        {
            if (f < 1 || f > filas) return;
            if (c < 1 || c > columnas) return;
            NodoDoble p = tablero.primerNodo();
            for (int i = 1; i < f; i++) p = (NodoDoble)p.celda.valor;
            p = p.Ld;
            for (int i = 1; i < c; i++) p = p.Ld;
            Celda cld = p.celda;
            if (cld.estado == States.Descubierta || cld.estado == States.Marcada) return;
            descubrir(cld);
            if ((int)cld.valor != 9) //verifica que la celda no sea una mina
            {
                if ((int)cld.valor == 0) //verifica que celda no tanga ninguna mina alrededor
                {
                    for (int i = f - 1; i <= f + 1; i++)
                    {
                        if (i < 1 || i > filas) continue;
                        for (int j = c - 1; j <= c + 1; j++)
                        {
                            if (i == f && j == c) continue;
                            if (j < 1 || j > columnas) continue;
                            revelarVecinas(i, j); //descubre todas celdas vecinas
                        }
                    }
                }
                redibujarTablero(); // actualiza a imagen visual del tablero, se redibuja el tablero
                if (celdasDescubiertas == celdasSinMina) gameWin(); //si todas las casillas sin minas ya fueros descubiertas se gana el juego
            }
            else
            {
                //se descubrio una mina por lo tanto se perdio el juego
                cld.imagen = (Bitmap)Properties.Resources.Bustted_Mine; //actualiza la imagen de la celda
                redibujarTablero(); // actualiza la imagen visual del tablero
                gameOver();
            }
        }
        private void clickDerecho(int f, int c)
        {
            if (f < 1 || f > filas) return;
            if (c < 1 || c > columnas) return;
            NodoDoble p = tablero.primerNodo();
            for (int i = 1; i < f; i++) p = (NodoDoble)p.celda.valor;
            p = p.Ld;
            for (int i = 1; i < c; i++) p = p.Ld;
            Celda cld = p.celda;
            if (cld.estado == States.Descubierta) return; //si la celda seleccionada esta descubierta no se hace nada y se retorna
            //verifica si la celda ya esta marcada, si es así la desmarca de lo contrario la marca
            if (cld.estado == States.Marcada) { desmarcar(cld); }
            else { marcar(cld); }
            //
            redibujarTablero(); //actualiza la imagen visual del tablero
        }
        private void revelarVecinas(int f, int c)
        {
            NodoDoble p = tablero.primerNodo();
            for (int i = 1; i < f; i++) p = (NodoDoble)p.celda.valor;
            p = p.Ld;
            for (int i = 1; i < c; i++) p = p.Ld;
            Celda cld = p.celda;
            if ((int)cld.valor != 9 && cld.estado == States.Cubierta)
            {
                this.descubrir(cld);
                if ((int)cld.valor == 0)
                {
                    for (int i = f - 1; i <= f + 1; i++)
                    {
                        if (i < 1 || i > filas) continue;
                        for (int j = c - 1; j <= c + 1; j++)
                        {
                            if (i == f && j == c) continue;
                            if (j < 1 || j > columnas) continue;
                            revelarVecinas(i, j);
                        }
                    }
                }
            }

        }
        private void gameOver()
        {
            NodoDoble cab, p, q;
            Celda cld;
            cab = tablero.nodoCabeza();
            p = tablero.primerNodo();
            while (p != cab)
            {
                q = p.Ld;
                while (q != p)
                {
                    cld = q.celda;
                    if ((int)cld.valor == 9) descubrir(cld); //descubre las casillas que son mina
                    q = q.Ld;
                }
                p = (NodoDoble)p.celda.valor;
            }
            banderas = 0;
            lbl_Banderas.Text = banderas.ToString();
            MessageBox.Show("Has perdido", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btn_Reiniciar.Text = "Volver a Jugar";
            IsPlaying = false; //se actualiza en valor de IsPlaying que indica si se esta juegando o no
        }
        private void gameWin()
        {
            NodoDoble cab, p, q;
            Celda cld;
            cab = tablero.nodoCabeza();
            p = tablero.primerNodo();
            while (p != cab)
            {
                q = p.Ld;
                while (q != p)
                {
                    cld = q.celda;
                    if ((int)cld.valor == 9) descubrir(cld); // se descubren las cassillas con mina
                    q = q.Ld;
                }
                p = (NodoDoble)p.celda.valor;
            }
            banderas = 0;
            lbl_Banderas.Text = banderas.ToString();
            MessageBox.Show("!Enhorabuena! Has ganado", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Reiniciar.Text = "Volver a Jugar";
            IsPlaying = false; //se actualiza en valor de IsPlaying que indica si se esta juegando o no
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!IsPlaying) return; //si no se esta jugando no se hace nada y se retorna
            if (btn_Reiniciar.Enabled == false) btn_Reiniciar.Enabled = true; //habilita la posibilidad de reiniciar el juego una vez se ha dado el primer click
            if (e.Button == MouseButtons.Left) //se verifica si se hizo click izquierdo
            {
                //se obtiene la popsicion en la que se hizo click
                //se divide por el tamaño de la celda y se le suma 1 para obtener asi la fila y columna correspondiente
                int f = (int)(e.Y / tamCelda.Height) + 1;
                int c = (int)(e.X / tamCelda.Width) + 1;
                clickIzquierdo(f, c);
            }
            else if (e.Button == MouseButtons.Right) //se verifica si se hizo click derecho
            {
                int f = (int)(e.Y / tamCelda.Height) + 1;
                int c = (int)(e.X / tamCelda.Width) + 1;
                clickDerecho(f, c);
            }
        }
        private void redibujarTablero()
        {
            Canvas.Invalidate(); //se actualiza la imagen visual del tablero, es decir se redibuja
        }
        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego(); // inicia un nuevo jugeo
            redibujarTablero(); // actualiza la imagen visual del tablero
        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close(); //
        }
    }
}
