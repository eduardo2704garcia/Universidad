namespace P2_D2_Algoritmos_GarciaE.UI
{
    partial class FrmRecorte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecorte));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.btnDibujarVentana = new System.Windows.Forms.Button();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(520, 125);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(678, 430);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algoritmos de Recorte";
            // 
            // cbAlgoritmo
            // 
            this.cbAlgoritmo.BackColor = System.Drawing.Color.MediumOrchid;
            this.cbAlgoritmo.ForeColor = System.Drawing.Color.GhostWhite;
            this.cbAlgoritmo.FormattingEnabled = true;
            this.cbAlgoritmo.Location = new System.Drawing.Point(73, 104);
            this.cbAlgoritmo.Name = "cbAlgoritmo";
            this.cbAlgoritmo.Size = new System.Drawing.Size(216, 24);
            this.cbAlgoritmo.TabIndex = 2;
            // 
            // btnDibujarVentana
            // 
            this.btnDibujarVentana.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnDibujarVentana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujarVentana.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDibujarVentana.Location = new System.Drawing.Point(312, 99);
            this.btnDibujarVentana.Name = "btnDibujarVentana";
            this.btnDibujarVentana.Size = new System.Drawing.Size(176, 33);
            this.btnDibujarVentana.TabIndex = 3;
            this.btnDibujarVentana.Text = "Dibujar Ventana";
            this.btnDibujarVentana.UseVisualStyleBackColor = false;
            this.btnDibujarVentana.Click += new System.EventHandler(this.btnDibujarVentana_Click);
            // 
            // btnRecortar
            // 
            this.btnRecortar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnRecortar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecortar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnRecortar.Location = new System.Drawing.Point(126, 319);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(278, 62);
            this.btnRecortar.TabIndex = 4;
            this.btnRecortar.Text = "RECORTAR";
            this.btnRecortar.UseVisualStyleBackColor = false;
            this.btnRecortar.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLimpiar.Location = new System.Drawing.Point(126, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(278, 62);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnVolver.Location = new System.Drawing.Point(126, 455);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(278, 62);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblPuntos.Location = new System.Drawing.Point(516, 99);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(74, 23);
            this.lblPuntos.TabIndex = 7;
            this.lblPuntos.Text = "Puntos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(195, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 158);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRecorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1204, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRecortar);
            this.Controls.Add(this.btnDibujarVentana);
            this.Controls.Add(this.cbAlgoritmo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmRecorte";
            this.Text = "FrmRecorte";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlgoritmo;
        private System.Windows.Forms.Button btnDibujarVentana;
        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}