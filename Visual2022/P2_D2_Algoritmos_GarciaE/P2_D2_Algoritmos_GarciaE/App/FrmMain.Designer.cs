namespace P2_D2_Algoritmos_GarciaE.App
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnRecorte = new System.Windows.Forms.Button();
            this.btnCurvas = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.btnRemasterización = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecorte
            // 
            this.btnRecorte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorte.Location = new System.Drawing.Point(645, 302);
            this.btnRecorte.Name = "btnRecorte";
            this.btnRecorte.Size = new System.Drawing.Size(221, 68);
            this.btnRecorte.TabIndex = 0;
            this.btnRecorte.Text = "Algoritmo Recorte";
            this.btnRecorte.UseVisualStyleBackColor = true;
            this.btnRecorte.Click += new System.EventHandler(this.btnRecorte_Click);
            // 
            // btnCurvas
            // 
            this.btnCurvas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurvas.Location = new System.Drawing.Point(921, 302);
            this.btnCurvas.Name = "btnCurvas";
            this.btnCurvas.Size = new System.Drawing.Size(221, 68);
            this.btnCurvas.TabIndex = 1;
            this.btnCurvas.Text = "Algoritmo Curvas";
            this.btnCurvas.UseVisualStyleBackColor = true;
            this.btnCurvas.Click += new System.EventHandler(this.btnCurvas_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelleno.Location = new System.Drawing.Point(645, 392);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(221, 68);
            this.btnRelleno.TabIndex = 2;
            this.btnRelleno.Text = "Algoritmo Relleno";
            this.btnRelleno.UseVisualStyleBackColor = true;
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // btnRemasterización
            // 
            this.btnRemasterización.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemasterización.Location = new System.Drawing.Point(921, 392);
            this.btnRemasterización.Name = "btnRemasterización";
            this.btnRemasterización.Size = new System.Drawing.Size(221, 68);
            this.btnRemasterización.TabIndex = 3;
            this.btnRemasterización.Text = "Algoritmo Remasterización";
            this.btnRemasterización.UseVisualStyleBackColor = true;
            this.btnRemasterización.Click += new System.EventHandler(this.btnRemasterizacion_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(615, 45);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(364, 133);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1019, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Realizado Por Eduardo García";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnRemasterización);
            this.Controls.Add(this.btnRelleno);
            this.Controls.Add(this.btnCurvas);
            this.Controls.Add(this.btnRecorte);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecorte;
        private System.Windows.Forms.Button btnCurvas;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.Button btnRemasterización;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}