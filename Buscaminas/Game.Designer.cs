namespace Buscaminas
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Banderas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Minas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Volver);
            this.panel2.Controls.Add(this.btn_Reiniciar);
            this.panel2.Location = new System.Drawing.Point(10, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 23);
            this.panel2.TabIndex = 1;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Volver.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Volver.Location = new System.Drawing.Point(125, 0);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Reiniciar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Reiniciar.Location = new System.Drawing.Point(0, 0);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(110, 23);
            this.btn_Reiniciar.TabIndex = 0;
            this.btn_Reiniciar.Text = "button1";
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_Banderas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbl_Minas);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 15);
            this.panel3.TabIndex = 2;
            // 
            // lbl_Banderas
            // 
            this.lbl_Banderas.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Banderas.Location = new System.Drawing.Point(162, 0);
            this.lbl_Banderas.Name = "lbl_Banderas";
            this.lbl_Banderas.Size = new System.Drawing.Size(38, 15);
            this.lbl_Banderas.TabIndex = 3;
            this.lbl_Banderas.Text = "label4";
            this.lbl_Banderas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(93, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Banderas:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Minas
            // 
            this.lbl_Minas.Location = new System.Drawing.Point(40, 0);
            this.lbl_Minas.Name = "lbl_Minas";
            this.lbl_Minas.Size = new System.Drawing.Size(37, 15);
            this.lbl_Minas.TabIndex = 1;
            this.lbl_Minas.Text = "label2";
            this.lbl_Minas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Canvas
            // 
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Canvas.Location = new System.Drawing.Point(10, 55);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(200, 140);
            this.Canvas.TabIndex = 3;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(219, 206);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Buscaminas";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Banderas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Minas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Canvas;
    }
}