namespace Parcial2.Algoritmos
{
    partial class FrmSutherland
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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblCf = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(509, 30);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(603, 492);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(152, 37);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(139, 22);
            this.txtX1.TabIndex = 1;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(325, 37);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(139, 22);
            this.txtY1.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(152, 84);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(139, 22);
            this.txtX2.TabIndex = 3;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(325, 84);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(139, 22);
            this.txtY2.TabIndex = 4;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(42, 43);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(81, 16);
            this.lblXi.TabIndex = 5;
            this.lblXi.Text = "Punto Inicial:";
            // 
            // lblCf
            // 
            this.lblCf.AutoSize = true;
            this.lblCf.Location = new System.Drawing.Point(42, 87);
            this.lblCf.Name = "lblCf";
            this.lblCf.Size = new System.Drawing.Size(76, 16);
            this.lblCf.TabIndex = 6;
            this.lblCf.Text = "Punto Final:";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(173, 127);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(201, 46);
            this.btnDibujar.TabIndex = 7;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // FrmSutherland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 535);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.lblCf);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmSutherland";
            this.Text = "FrmSutherland";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblCf;
        private System.Windows.Forms.Button btnDibujar;
    }
}