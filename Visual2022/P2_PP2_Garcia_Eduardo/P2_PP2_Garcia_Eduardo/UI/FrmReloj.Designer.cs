namespace P2_PP2_Garcia_Eduardo.UI
{
    partial class FrmReloj
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
            this.components = new System.ComponentModel.Container();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picCanvas.Location = new System.Drawing.Point(258, 60);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(701, 418);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "RELOJ  FUNCIONAL";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmpezar.Location = new System.Drawing.Point(94, 60);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(110, 60);
            this.btnEmpezar.TabIndex = 2;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // FrmReloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1203, 572);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmReloj";
            this.Text = "FrmReloj";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpezar;
    }
}