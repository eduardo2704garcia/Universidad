namespace Figura1
{
    partial class FrmEjercicio2
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.tkProgres = new System.Windows.Forms.TrackBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkProgres)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(316, 41);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(473, 350);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // tkProgres
            // 
            this.tkProgres.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tkProgres.Location = new System.Drawing.Point(41, 141);
            this.tkProgres.Maximum = 20;
            this.tkProgres.Minimum = 5;
            this.tkProgres.Name = "tkProgres";
            this.tkProgres.Size = new System.Drawing.Size(254, 56);
            this.tkProgres.TabIndex = 1;
            this.tkProgres.Value = 5;
            this.tkProgres.Scroll += new System.EventHandler(this.tkProgres_Scroll);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(46, 77);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // FrmEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tkProgres);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmEjercicio2";
            this.Text = "FrmEjercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkProgres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TrackBar tkProgres;
        private System.Windows.Forms.Label lblCantidad;
    }
}