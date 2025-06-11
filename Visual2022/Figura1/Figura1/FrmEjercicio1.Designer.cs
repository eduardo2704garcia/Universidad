namespace Figura1
{
    partial class FrmEjercicio1
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
            this.tkProgres = new System.Windows.Forms.TrackBar();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkProgres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tkProgres
            // 
            this.tkProgres.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tkProgres.Location = new System.Drawing.Point(39, 103);
            this.tkProgres.Maximum = 20;
            this.tkProgres.Minimum = 5;
            this.tkProgres.Name = "tkProgres";
            this.tkProgres.Size = new System.Drawing.Size(265, 56);
            this.tkProgres.TabIndex = 0;
            this.tkProgres.Value = 5;
            this.tkProgres.Scroll += new System.EventHandler(this.tkProgres_Scroll);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(364, 81);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(409, 300);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(42, 58);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(79, 16);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "CANTIDAD:";
            // 
            // FrmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.tkProgres);
            this.Name = "FrmEjercicio1";
            this.Text = "FrmEjercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.tkProgres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkProgres;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblcantidad;
    }
}