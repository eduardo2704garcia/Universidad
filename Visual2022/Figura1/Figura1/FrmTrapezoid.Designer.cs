namespace Figura1
{
    partial class FrmTrapezoid
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
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblL1 = new System.Windows.Forms.Label();
            this.lblL2 = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblGrafic = new System.Windows.Forms.Label();
            this.rbtnTrapecio = new System.Windows.Forms.RadioButton();
            this.rbtnTrapezoid = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(452, 90);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(767, 497);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Gold;
            this.btnCalculate.Location = new System.Drawing.Point(12, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 46);
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
            this.btnReset.Location = new System.Drawing.Point(158, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 46);
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
            this.btnExit.Location = new System.Drawing.Point(307, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPerimeter.Location = new System.Drawing.Point(218, 449);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(189, 22);
            this.txtPerimeter.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtArea.Location = new System.Drawing.Point(218, 508);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(189, 22);
            this.txtArea.TabIndex = 5;
            // 
            // txtL2
            // 
            this.txtL2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtL2.Location = new System.Drawing.Point(218, 316);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(189, 22);
            this.txtL2.TabIndex = 6;
            // 
            // txtL1
            // 
            this.txtL1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtL1.Location = new System.Drawing.Point(218, 266);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(189, 22);
            this.txtL1.TabIndex = 7;
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtH.Location = new System.Drawing.Point(218, 215);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(189, 22);
            this.txtH.TabIndex = 8;
            // 
            // txtB2
            // 
            this.txtB2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtB2.Location = new System.Drawing.Point(218, 166);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(189, 22);
            this.txtB2.TabIndex = 9;
            // 
            // txtB1
            // 
            this.txtB1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtB1.Location = new System.Drawing.Point(218, 118);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(189, 22);
            this.txtB1.TabIndex = 10;
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB1.Location = new System.Drawing.Point(30, 117);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(119, 23);
            this.lblB1.TabIndex = 11;
            this.lblB1.Text = "Base Mayor:";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblB2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblB2.Location = new System.Drawing.Point(30, 166);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(119, 23);
            this.lblB2.TabIndex = 12;
            this.lblB2.Text = "Base Menor:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(30, 218);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(71, 23);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "Altura:";
            // 
            // lblL1
            // 
            this.lblL1.AutoSize = true;
            this.lblL1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL1.Location = new System.Drawing.Point(30, 272);
            this.lblL1.Name = "lblL1";
            this.lblL1.Size = new System.Drawing.Size(75, 23);
            this.lblL1.TabIndex = 14;
            this.lblL1.Text = "Lado 1:";
            // 
            // lblL2
            // 
            this.lblL2.AutoSize = true;
            this.lblL2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL2.Location = new System.Drawing.Point(30, 319);
            this.lblL2.Name = "lblL2";
            this.lblL2.Size = new System.Drawing.Size(75, 23);
            this.lblL2.TabIndex = 15;
            this.lblL2.Text = "Lado 2:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(30, 449);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(103, 23);
            this.lblPerimeter.TabIndex = 16;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(30, 511);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(59, 23);
            this.lblArea.TabIndex = 17;
            this.lblArea.Text = "Área:";
            // 
            // lblGrafic
            // 
            this.lblGrafic.AutoSize = true;
            this.lblGrafic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrafic.Location = new System.Drawing.Point(471, 80);
            this.lblGrafic.Name = "lblGrafic";
            this.lblGrafic.Size = new System.Drawing.Size(82, 23);
            this.lblGrafic.TabIndex = 18;
            this.lblGrafic.Text = "Gráfico:";
            // 
            // rbtnTrapecio
            // 
            this.rbtnTrapecio.AutoSize = true;
            this.rbtnTrapecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTrapecio.Location = new System.Drawing.Point(52, 76);
            this.rbtnTrapecio.Name = "rbtnTrapecio";
            this.rbtnTrapecio.Size = new System.Drawing.Size(105, 27);
            this.rbtnTrapecio.TabIndex = 19;
            this.rbtnTrapecio.TabStop = true;
            this.rbtnTrapecio.Text = "Trapecio";
            this.rbtnTrapecio.UseVisualStyleBackColor = true;
            // 
            // rbtnTrapezoid
            // 
            this.rbtnTrapezoid.AutoSize = true;
            this.rbtnTrapezoid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTrapezoid.Location = new System.Drawing.Point(235, 76);
            this.rbtnTrapezoid.Name = "rbtnTrapezoid";
            this.rbtnTrapezoid.Size = new System.Drawing.Size(126, 27);
            this.rbtnTrapezoid.TabIndex = 20;
            this.rbtnTrapezoid.TabStop = true;
            this.rbtnTrapezoid.Text = "Trapezoide";
            this.rbtnTrapezoid.UseVisualStyleBackColor = true;
            // 
            // FrmTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 609);
            this.Controls.Add(this.rbtnTrapezoid);
            this.Controls.Add(this.rbtnTrapecio);
            this.Controls.Add(this.lblGrafic);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblL2);
            this.Controls.Add(this.lblL1);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblB2);
            this.Controls.Add(this.lblB1);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtL1);
            this.Controls.Add(this.txtL2);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmTrapezoid";
            this.Text = "FrmTrapezoid";
            this.Load += new System.EventHandler(this.FrmTrapezoid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblL1;
        private System.Windows.Forms.Label lblL2;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblGrafic;
        private System.Windows.Forms.RadioButton rbtnTrapecio;
        private System.Windows.Forms.RadioButton rbtnTrapezoid;
    }
}