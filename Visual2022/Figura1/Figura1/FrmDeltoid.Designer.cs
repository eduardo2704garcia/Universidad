namespace Figura1
{
    partial class FrmDeltoid
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblGrafic = new System.Windows.Forms.Label();
            this.lblDmajor = new System.Windows.Forms.Label();
            this.lblDminor = new System.Windows.Forms.Label();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.txtDmajor = new System.Windows.Forms.TextBox();
            this.txtDminor = new System.Windows.Forms.TextBox();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(398, 115);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(755, 476);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(252, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Location = new System.Drawing.Point(140, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 45);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Gold;
            this.btnCalculate.Location = new System.Drawing.Point(28, 359);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 45);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(31, 445);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(103, 23);
            this.lblPerimeter.TabIndex = 14;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(31, 492);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(59, 23);
            this.lblArea.TabIndex = 15;
            this.lblArea.Text = "Área:";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPerimeter.Location = new System.Drawing.Point(167, 445);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(191, 22);
            this.txtPerimeter.TabIndex = 19;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtArea.Location = new System.Drawing.Point(167, 492);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(191, 22);
            this.txtArea.TabIndex = 20;
            // 
            // lblGrafic
            // 
            this.lblGrafic.AutoSize = true;
            this.lblGrafic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrafic.Location = new System.Drawing.Point(434, 104);
            this.lblGrafic.Name = "lblGrafic";
            this.lblGrafic.Size = new System.Drawing.Size(82, 23);
            this.lblGrafic.TabIndex = 21;
            this.lblGrafic.Text = "Gráfico:";
            // 
            // lblDmajor
            // 
            this.lblDmajor.AutoSize = true;
            this.lblDmajor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmajor.Location = new System.Drawing.Point(31, 130);
            this.lblDmajor.Name = "lblDmajor";
            this.lblDmajor.Size = new System.Drawing.Size(157, 23);
            this.lblDmajor.TabIndex = 22;
            this.lblDmajor.Text = "Diagonal  Mayor:";
            // 
            // lblDminor
            // 
            this.lblDminor.AutoSize = true;
            this.lblDminor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDminor.Location = new System.Drawing.Point(31, 180);
            this.lblDminor.Name = "lblDminor";
            this.lblDminor.Size = new System.Drawing.Size(152, 23);
            this.lblDminor.TabIndex = 23;
            this.lblDminor.Text = "Diagonal Menor:";
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideA.Location = new System.Drawing.Point(31, 241);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(78, 23);
            this.lblSideA.TabIndex = 24;
            this.lblSideA.Text = "Lado A:";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideB.Location = new System.Drawing.Point(31, 297);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(78, 23);
            this.lblSideB.TabIndex = 25;
            this.lblSideB.Text = "Lado B:";
            // 
            // txtDmajor
            // 
            this.txtDmajor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDmajor.Location = new System.Drawing.Point(194, 132);
            this.txtDmajor.Name = "txtDmajor";
            this.txtDmajor.Size = new System.Drawing.Size(191, 22);
            this.txtDmajor.TabIndex = 26;
            // 
            // txtDminor
            // 
            this.txtDminor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDminor.Location = new System.Drawing.Point(194, 182);
            this.txtDminor.Name = "txtDminor";
            this.txtDminor.Size = new System.Drawing.Size(191, 22);
            this.txtDminor.TabIndex = 27;
            // 
            // txtSideA
            // 
            this.txtSideA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSideA.Location = new System.Drawing.Point(194, 243);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(191, 22);
            this.txtSideA.TabIndex = 28;
            // 
            // txtSideB
            // 
            this.txtSideB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSideB.Location = new System.Drawing.Point(194, 299);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(191, 22);
            this.txtSideB.TabIndex = 29;
            // 
            // FrmDeltoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 603);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.txtDminor);
            this.Controls.Add(this.txtDmajor);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.lblDminor);
            this.Controls.Add(this.lblDmajor);
            this.Controls.Add(this.lblGrafic);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmDeltoid";
            this.Text = "FrmDeltoid";
            this.Load += new System.EventHandler(this.FrmDeltoid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblGrafic;
        private System.Windows.Forms.Label lblDmajor;
        private System.Windows.Forms.Label lblDminor;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.TextBox txtDmajor;
        private System.Windows.Forms.TextBox txtDminor;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
    }
}