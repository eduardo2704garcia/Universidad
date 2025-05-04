namespace Figura1
{
    partial class FrmRhombus
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDiagonal1 = new System.Windows.Forms.TextBox();
            this.txtDiagonal2 = new System.Windows.Forms.TextBox();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblDiagonal1 = new System.Windows.Forms.Label();
            this.lblDiagonal2 = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblGrafic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(471, 107);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(689, 476);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Gold;
            this.btnCalculate.Location = new System.Drawing.Point(17, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 45);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Location = new System.Drawing.Point(161, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(319, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDiagonal1
            // 
            this.txtDiagonal1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDiagonal1.Location = new System.Drawing.Point(234, 113);
            this.txtDiagonal1.Name = "txtDiagonal1";
            this.txtDiagonal1.Size = new System.Drawing.Size(191, 22);
            this.txtDiagonal1.TabIndex = 4;
            // 
            // txtDiagonal2
            // 
            this.txtDiagonal2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDiagonal2.Location = new System.Drawing.Point(234, 176);
            this.txtDiagonal2.Name = "txtDiagonal2";
            this.txtDiagonal2.Size = new System.Drawing.Size(191, 22);
            this.txtDiagonal2.TabIndex = 5;
            // 
            // txtSide
            // 
            this.txtSide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSide.Location = new System.Drawing.Point(234, 251);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(191, 22);
            this.txtSide.TabIndex = 6;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPerimeter.Location = new System.Drawing.Point(234, 410);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(191, 22);
            this.txtPerimeter.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtArea.Location = new System.Drawing.Point(234, 475);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(191, 22);
            this.txtArea.TabIndex = 8;
            // 
            // lblDiagonal1
            // 
            this.lblDiagonal1.AutoSize = true;
            this.lblDiagonal1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonal1.Location = new System.Drawing.Point(40, 107);
            this.lblDiagonal1.Name = "lblDiagonal1";
            this.lblDiagonal1.Size = new System.Drawing.Size(152, 23);
            this.lblDiagonal1.TabIndex = 9;
            this.lblDiagonal1.Text = "Diagonal Mayor:";
            // 
            // lblDiagonal2
            // 
            this.lblDiagonal2.AutoSize = true;
            this.lblDiagonal2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonal2.Location = new System.Drawing.Point(40, 179);
            this.lblDiagonal2.Name = "lblDiagonal2";
            this.lblDiagonal2.Size = new System.Drawing.Size(152, 23);
            this.lblDiagonal2.TabIndex = 10;
            this.lblDiagonal2.Text = "Diagonal Menor:";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(40, 254);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(60, 23);
            this.lblSide.TabIndex = 11;
            this.lblSide.Text = "Lado:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(40, 413);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(103, 23);
            this.lblPerimeter.TabIndex = 12;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(40, 478);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(59, 23);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Área:";
            // 
            // lblGrafic
            // 
            this.lblGrafic.AutoSize = true;
            this.lblGrafic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrafic.Location = new System.Drawing.Point(489, 96);
            this.lblGrafic.Name = "lblGrafic";
            this.lblGrafic.Size = new System.Drawing.Size(82, 23);
            this.lblGrafic.TabIndex = 14;
            this.lblGrafic.Text = "Gráfico:";
            // 
            // FrmRhombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 594);
            this.Controls.Add(this.lblGrafic);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.lblDiagonal2);
            this.Controls.Add(this.lblDiagonal1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.txtDiagonal2);
            this.Controls.Add(this.txtDiagonal1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmRhombus";
            this.Text = "FrmRhombus";
            this.Load += new System.EventHandler(this.FrmRhombus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDiagonal1;
        private System.Windows.Forms.TextBox txtDiagonal2;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblDiagonal1;
        private System.Windows.Forms.Label lblDiagonal2;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblGrafic;
    }
}