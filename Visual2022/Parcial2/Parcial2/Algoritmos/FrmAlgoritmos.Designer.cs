namespace Parcial2.Algoritmos
{
    partial class FrmAlgoritmos
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
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.txtInitialPoint = new System.Windows.Forms.TextBox();
            this.txtFinalPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DDA = new System.Windows.Forms.CheckBox();
            this.Breseham = new System.Windows.Forms.CheckBox();
            this.PuntoMedio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCanvas.Location = new System.Drawing.Point(119, 36);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(957, 370);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_calculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.Color.Yellow;
            this.btn_calculate.Location = new System.Drawing.Point(282, 466);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(196, 61);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btncalculate_click);
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_clean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.ForeColor = System.Drawing.Color.Lime;
            this.btn_clean.Location = new System.Drawing.Point(782, 466);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(193, 61);
            this.btn_clean.TabIndex = 2;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btnclean_click);
            // 
            // txtInitialPoint
            // 
            this.txtInitialPoint.Location = new System.Drawing.Point(225, 425);
            this.txtInitialPoint.Name = "txtInitialPoint";
            this.txtInitialPoint.Size = new System.Drawing.Size(253, 22);
            this.txtInitialPoint.TabIndex = 3;
            // 
            // txtFinalPoint
            // 
            this.txtFinalPoint.Location = new System.Drawing.Point(782, 419);
            this.txtFinalPoint.Name = "txtFinalPoint";
            this.txtFinalPoint.Size = new System.Drawing.Size(294, 22);
            this.txtFinalPoint.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puntos Iniciales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Puntos Finales:";
            // 
            // DDA
            // 
            this.DDA.AutoSize = true;
            this.DDA.Location = new System.Drawing.Point(526, 425);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(118, 20);
            this.DDA.TabIndex = 7;
            this.DDA.Text = "Algoritmo DDA";
            this.DDA.UseVisualStyleBackColor = true;
            // 
            // Breseham
            // 
            this.Breseham.AutoSize = true;
            this.Breseham.Location = new System.Drawing.Point(526, 466);
            this.Breseham.Name = "Breseham";
            this.Breseham.Size = new System.Drawing.Size(151, 20);
            this.Breseham.TabIndex = 8;
            this.Breseham.Text = "Algoritmo Breseham";
            this.Breseham.UseVisualStyleBackColor = true;
            // 
            // PuntoMedio
            // 
            this.PuntoMedio.AutoSize = true;
            this.PuntoMedio.Location = new System.Drawing.Point(526, 507);
            this.PuntoMedio.Name = "PuntoMedio";
            this.PuntoMedio.Size = new System.Drawing.Size(186, 20);
            this.PuntoMedio.TabIndex = 9;
            this.PuntoMedio.Text = "Algoritmo del Punto Medio";
            this.PuntoMedio.UseVisualStyleBackColor = true;
            // 
            // FrmAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 559);
            this.Controls.Add(this.PuntoMedio);
            this.Controls.Add(this.Breseham);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinalPoint);
            this.Controls.Add(this.txtInitialPoint);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmAlgoritmos";
            this.Text = "Algoritmos";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.TextBox txtInitialPoint;
        private System.Windows.Forms.TextBox txtFinalPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DDA;
        private System.Windows.Forms.CheckBox Breseham;
        private System.Windows.Forms.CheckBox PuntoMedio;
    }
}