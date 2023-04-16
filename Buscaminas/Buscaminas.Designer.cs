namespace Buscaminas
{
    partial class Buscaminas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscaminas));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_principiante = new System.Windows.Forms.Label();
            this.lbl_intermedio = new System.Windows.Forms.Label();
            this.lbl_experto = new System.Windows.Forms.Label();
            this.lbl_personalizado = new System.Windows.Forms.Label();
            this.lbl_filas = new System.Windows.Forms.Label();
            this.lbl_columnas = new System.Windows.Forms.Label();
            this.lbl_minas = new System.Windows.Forms.Label();
            this.numFilas = new System.Windows.Forms.NumericUpDown();
            this.numColumnas = new System.Windows.Forms.NumericUpDown();
            this.numMinas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(174, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el modo de juego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_principiante
            // 
            this.lbl_principiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_principiante.Location = new System.Drawing.Point(174, 73);
            this.lbl_principiante.Name = "lbl_principiante";
            this.lbl_principiante.Size = new System.Drawing.Size(140, 30);
            this.lbl_principiante.TabIndex = 2;
            this.lbl_principiante.Text = "Principiante";
            this.lbl_principiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_principiante.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_principiante.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_principiante.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // lbl_intermedio
            // 
            this.lbl_intermedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intermedio.Location = new System.Drawing.Point(174, 103);
            this.lbl_intermedio.Name = "lbl_intermedio";
            this.lbl_intermedio.Size = new System.Drawing.Size(140, 30);
            this.lbl_intermedio.TabIndex = 3;
            this.lbl_intermedio.Text = "Intermedio";
            this.lbl_intermedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_intermedio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_intermedio.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_intermedio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // lbl_experto
            // 
            this.lbl_experto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_experto.Location = new System.Drawing.Point(174, 133);
            this.lbl_experto.Name = "lbl_experto";
            this.lbl_experto.Size = new System.Drawing.Size(140, 30);
            this.lbl_experto.TabIndex = 4;
            this.lbl_experto.Text = "Experto";
            this.lbl_experto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_experto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_experto.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_experto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // lbl_personalizado
            // 
            this.lbl_personalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personalizado.Location = new System.Drawing.Point(174, 163);
            this.lbl_personalizado.Name = "lbl_personalizado";
            this.lbl_personalizado.Size = new System.Drawing.Size(140, 30);
            this.lbl_personalizado.TabIndex = 5;
            this.lbl_personalizado.Text = "Personalizado";
            this.lbl_personalizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_personalizado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_personalizado.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_personalizado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            // 
            // lbl_filas
            // 
            this.lbl_filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filas.Location = new System.Drawing.Point(176, 202);
            this.lbl_filas.Name = "lbl_filas";
            this.lbl_filas.Size = new System.Drawing.Size(70, 22);
            this.lbl_filas.TabIndex = 7;
            this.lbl_filas.Text = "Filas:";
            this.lbl_filas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_columnas
            // 
            this.lbl_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_columnas.Location = new System.Drawing.Point(176, 224);
            this.lbl_columnas.Name = "lbl_columnas";
            this.lbl_columnas.Size = new System.Drawing.Size(70, 22);
            this.lbl_columnas.TabIndex = 8;
            this.lbl_columnas.Text = "Columnas:";
            this.lbl_columnas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_minas
            // 
            this.lbl_minas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minas.Location = new System.Drawing.Point(176, 246);
            this.lbl_minas.Name = "lbl_minas";
            this.lbl_minas.Size = new System.Drawing.Size(70, 22);
            this.lbl_minas.TabIndex = 9;
            this.lbl_minas.Text = "Minas";
            this.lbl_minas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numFilas
            // 
            this.numFilas.Location = new System.Drawing.Point(252, 206);
            this.numFilas.Name = "numFilas";
            this.numFilas.Size = new System.Drawing.Size(62, 20);
            this.numFilas.TabIndex = 10;
            this.numFilas.ValueChanged += new System.EventHandler(this.numFilas_ValueChanged);
            // 
            // numColumnas
            // 
            this.numColumnas.Location = new System.Drawing.Point(252, 228);
            this.numColumnas.Name = "numColumnas";
            this.numColumnas.Size = new System.Drawing.Size(62, 20);
            this.numColumnas.TabIndex = 11;
            this.numColumnas.ValueChanged += new System.EventHandler(this.numColumnas_ValueChanged);
            // 
            // numMinas
            // 
            this.numMinas.Location = new System.Drawing.Point(252, 250);
            this.numMinas.Name = "numMinas";
            this.numMinas.Size = new System.Drawing.Size(62, 20);
            this.numMinas.TabIndex = 12;
            // 
            // Buscaminas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.numMinas);
            this.Controls.Add(this.numColumnas);
            this.Controls.Add(this.numFilas);
            this.Controls.Add(this.lbl_minas);
            this.Controls.Add(this.lbl_columnas);
            this.Controls.Add(this.lbl_filas);
            this.Controls.Add(this.lbl_personalizado);
            this.Controls.Add(this.lbl_experto);
            this.Controls.Add(this.lbl_intermedio);
            this.Controls.Add(this.lbl_principiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscaminas";
            this.Text = "Buscaminas";
            ((System.ComponentModel.ISupportInitialize)(this.numFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_principiante;
        private System.Windows.Forms.Label lbl_intermedio;
        private System.Windows.Forms.Label lbl_experto;
        private System.Windows.Forms.Label lbl_personalizado;
        private System.Windows.Forms.Label lbl_filas;
        private System.Windows.Forms.Label lbl_columnas;
        private System.Windows.Forms.Label lbl_minas;
        private System.Windows.Forms.NumericUpDown numFilas;
        private System.Windows.Forms.NumericUpDown numColumnas;
        private System.Windows.Forms.NumericUpDown numMinas;
    }
}

