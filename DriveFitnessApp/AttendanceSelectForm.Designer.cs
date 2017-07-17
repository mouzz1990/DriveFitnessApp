namespace DriveFitnessApp
{
    partial class AttendanceSelectForm
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
            this.pAutoScan = new System.Windows.Forms.Panel();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pManualScan = new System.Windows.Forms.Panel();
            this.BtnManual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pAutoScan.SuspendLayout();
            this.pManualScan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAutoScan
            // 
            this.pAutoScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAutoScan.Controls.Add(this.BtnAuto);
            this.pAutoScan.Controls.Add(this.label2);
            this.pAutoScan.Controls.Add(this.label1);
            this.pAutoScan.Location = new System.Drawing.Point(20, 18);
            this.pAutoScan.Margin = new System.Windows.Forms.Padding(5);
            this.pAutoScan.Name = "pAutoScan";
            this.pAutoScan.Size = new System.Drawing.Size(250, 250);
            this.pAutoScan.TabIndex = 0;
            // 
            // BtnAuto
            // 
            this.BtnAuto.Image = global::DriveFitnessApp.Properties.Resources.QR_scanner;
            this.BtnAuto.Location = new System.Drawing.Point(50, 67);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(150, 150);
            this.BtnAuto.TabIndex = 2;
            this.BtnAuto.UseVisualStyleBackColor = true;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = " с помощью QR-кода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Учет посещения";
            // 
            // pManualScan
            // 
            this.pManualScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pManualScan.Controls.Add(this.BtnManual);
            this.pManualScan.Controls.Add(this.label4);
            this.pManualScan.Controls.Add(this.label3);
            this.pManualScan.Location = new System.Drawing.Point(294, 18);
            this.pManualScan.Margin = new System.Windows.Forms.Padding(5);
            this.pManualScan.Name = "pManualScan";
            this.pManualScan.Size = new System.Drawing.Size(250, 250);
            this.pManualScan.TabIndex = 1;
            // 
            // BtnManual
            // 
            this.BtnManual.Image = global::DriveFitnessApp.Properties.Resources.attendance_check;
            this.BtnManual.Location = new System.Drawing.Point(49, 67);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(150, 150);
            this.BtnManual.TabIndex = 2;
            this.BtnManual.UseVisualStyleBackColor = true;
            this.BtnManual.Click += new System.EventHandler(this.BtnManual_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "в ручном режиме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Учет посещения";
            // 
            // AttendanceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 285);
            this.Controls.Add(this.pManualScan);
            this.Controls.Add(this.pAutoScan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 309);
            this.MinimumSize = new System.Drawing.Size(571, 309);
            this.Name = "AttendanceSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет посещения клиентов";
            this.pAutoScan.ResumeLayout(false);
            this.pAutoScan.PerformLayout();
            this.pManualScan.ResumeLayout(false);
            this.pManualScan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAutoScan;
        private System.Windows.Forms.Panel pManualScan;
        private System.Windows.Forms.Button BtnAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}