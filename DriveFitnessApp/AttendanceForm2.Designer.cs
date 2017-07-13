namespace DriveFitnessApp
{
    partial class AttendanceForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpDateVisit = new System.Windows.Forms.DateTimePicker();
            this.BtnStartScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата посещения:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 1;
            this.numPrice.Location = new System.Drawing.Point(170, 23);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(72, 26);
            this.numPrice.TabIndex = 2;
            // 
            // dtpDateVisit
            // 
            this.dtpDateVisit.Location = new System.Drawing.Point(170, 65);
            this.dtpDateVisit.Name = "dtpDateVisit";
            this.dtpDateVisit.Size = new System.Drawing.Size(213, 26);
            this.dtpDateVisit.TabIndex = 3;
            // 
            // BtnStartScan
            // 
            this.BtnStartScan.Location = new System.Drawing.Point(71, 122);
            this.BtnStartScan.Name = "BtnStartScan";
            this.BtnStartScan.Size = new System.Drawing.Size(260, 100);
            this.BtnStartScan.TabIndex = 4;
            this.BtnStartScan.Text = "Запустить сканер";
            this.BtnStartScan.UseVisualStyleBackColor = true;
            this.BtnStartScan.Click += new System.EventHandler(this.BtnStartScan_Click);
            // 
            // AttendanceForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 267);
            this.Controls.Add(this.BtnStartScan);
            this.Controls.Add(this.dtpDateVisit);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AttendanceForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm2";
            this.Load += new System.EventHandler(this.AttendanceForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.DateTimePicker dtpDateVisit;
        private System.Windows.Forms.Button BtnStartScan;
    }
}