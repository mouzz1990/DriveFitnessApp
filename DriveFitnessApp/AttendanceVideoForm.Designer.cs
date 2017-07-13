namespace DriveFitnessApp
{
    partial class AttendanceVideoForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Плата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата посещения:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(169, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 20;
            this.lbDevices.Location = new System.Drawing.Point(27, 76);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(341, 124);
            this.lbDevices.TabIndex = 4;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(123, 206);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(127, 48);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Старт";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // pbWebCam
            // 
            this.pbWebCam.Location = new System.Drawing.Point(375, 12);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(300, 300);
            this.pbWebCam.TabIndex = 6;
            this.pbWebCam.TabStop = false;
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(27, 286);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(341, 26);
            this.txbResult.TabIndex = 7;
            // 
            // AttendanceVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 328);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.pbWebCam);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AttendanceVideoForm";
            this.Text = "AttendanceVideoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceVideoForm_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceVideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.TextBox txbResult;
    }
}