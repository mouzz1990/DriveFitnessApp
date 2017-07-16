namespace DriveFitnessApp
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.dtpVisit = new System.Windows.Forms.DateTimePicker();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pCheck = new System.Windows.Forms.Panel();
            this.BtnRemoveAttendance = new System.Windows.Forms.Button();
            this.pSubscription = new System.Windows.Forms.Panel();
            this.txbSubscriptionCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mcVisitation = new MPK_Calendar.MPK_Calendar();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.BtnCheckVisit = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pCheck.SuspendLayout();
            this.pSubscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVisit
            // 
            this.dtpVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVisit.Location = new System.Drawing.Point(196, 8);
            this.dtpVisit.Name = "dtpVisit";
            this.dtpVisit.Size = new System.Drawing.Size(200, 26);
            this.dtpVisit.TabIndex = 0;
            this.dtpVisit.ValueChanged += new System.EventHandler(this.dtpVisit_ValueChanged);
            // 
            // cmbGroup
            // 
            this.cmbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(86, 8);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(167, 28);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // lbClients
            // 
            this.lbClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 20;
            this.lbClients.Location = new System.Drawing.Point(17, 42);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(234, 384);
            this.lbClients.TabIndex = 2;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Группа:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbClients);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbGroup);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 443);
            this.panel1.TabIndex = 5;
            // 
            // pCheck
            // 
            this.pCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCheck.Controls.Add(this.BtnRemoveAttendance);
            this.pCheck.Controls.Add(this.pSubscription);
            this.pCheck.Controls.Add(this.label4);
            this.pCheck.Controls.Add(this.mcVisitation);
            this.pCheck.Controls.Add(this.numPrice);
            this.pCheck.Controls.Add(this.BtnCheckVisit);
            this.pCheck.Controls.Add(this.lbPrice);
            this.pCheck.Controls.Add(this.label2);
            this.pCheck.Controls.Add(this.dtpVisit);
            this.pCheck.Location = new System.Drawing.Point(286, 12);
            this.pCheck.Name = "pCheck";
            this.pCheck.Size = new System.Drawing.Size(401, 443);
            this.pCheck.TabIndex = 6;
            // 
            // BtnRemoveAttendance
            // 
            this.BtnRemoveAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRemoveAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRemoveAttendance.Location = new System.Drawing.Point(9, 381);
            this.BtnRemoveAttendance.Name = "BtnRemoveAttendance";
            this.BtnRemoveAttendance.Size = new System.Drawing.Size(142, 57);
            this.BtnRemoveAttendance.TabIndex = 13;
            this.BtnRemoveAttendance.Text = "Удалить посещение";
            this.BtnRemoveAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemoveAttendance.UseVisualStyleBackColor = true;
            this.BtnRemoveAttendance.Click += new System.EventHandler(this.BtnRemoveAttendance_Click);
            // 
            // pSubscription
            // 
            this.pSubscription.Controls.Add(this.txbSubscriptionCount);
            this.pSubscription.Controls.Add(this.label3);
            this.pSubscription.Location = new System.Drawing.Point(3, 70);
            this.pSubscription.Name = "pSubscription";
            this.pSubscription.Size = new System.Drawing.Size(397, 36);
            this.pSubscription.TabIndex = 12;
            // 
            // txbSubscriptionCount
            // 
            this.txbSubscriptionCount.Enabled = false;
            this.txbSubscriptionCount.Location = new System.Drawing.Point(312, 2);
            this.txbSubscriptionCount.Name = "txbSubscriptionCount";
            this.txbSubscriptionCount.Size = new System.Drawing.Size(81, 26);
            this.txbSubscriptionCount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кол-во занятий на абонементе:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(99, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Календарь посещений";
            // 
            // mcVisitation
            // 
            this.mcVisitation.AbbreviateWeekDayHeader = true;
            this.mcVisitation.ActiveMonthColor = System.Drawing.Color.White;
            this.mcVisitation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcVisitation.ApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mcVisitation.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mcVisitation.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.mcVisitation.BoldedDateFontColor = System.Drawing.Color.Red;
            this.mcVisitation.BoldedDates = new System.DateTime[0];
            this.mcVisitation.DisplayWeekendsDarker = false;
            this.mcVisitation.GridColor = System.Drawing.Color.Black;
            this.mcVisitation.HeaderColor = System.Drawing.Color.LightSteelBlue;
            this.mcVisitation.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mcVisitation.InactiveMonthColor = System.Drawing.Color.Silver;
            this.mcVisitation.intDay = 16;
            this.mcVisitation.intMonth = 7;
            this.mcVisitation.intYear = 2017;
            this.mcVisitation.Location = new System.Drawing.Point(9, 133);
            this.mcVisitation.Name = "mcVisitation";
            this.mcVisitation.NoApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mcVisitation.NonselectedDayFontColor = System.Drawing.Color.Black;
            this.mcVisitation.SelectedDate = new System.DateTime(2017, 7, 16, 16, 35, 8, 800);
            this.mcVisitation.SelectedDayColor = System.Drawing.Color.LightSteelBlue;
            this.mcVisitation.SelectedDayFontColor = System.Drawing.Color.White;
            this.mcVisitation.ShowCurrentMonthInDay = false;
            this.mcVisitation.ShowGrid = false;
            this.mcVisitation.ShowPrevNextButton = true;
            this.mcVisitation.Size = new System.Drawing.Size(387, 242);
            this.mcVisitation.TabIndex = 8;
            this.mcVisitation.SelectedDateChanged += new MPK_Calendar.SelectedDateChangedEventHandler(this.mcVisitation_SelectedDateChanged);
            // 
            // numPrice
            // 
            this.numPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrice.DecimalPlaces = 1;
            this.numPrice.Location = new System.Drawing.Point(315, 40);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(81, 26);
            this.numPrice.TabIndex = 6;
            this.numPrice.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // BtnCheckVisit
            // 
            this.BtnCheckVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCheckVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCheckVisit.Image = global::DriveFitnessApp.Properties.Resources.Attendance;
            this.BtnCheckVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckVisit.Location = new System.Drawing.Point(209, 381);
            this.BtnCheckVisit.Name = "BtnCheckVisit";
            this.BtnCheckVisit.Size = new System.Drawing.Size(187, 57);
            this.BtnCheckVisit.TabIndex = 5;
            this.BtnCheckVisit.Text = "Зафиксировать посещение";
            this.BtnCheckVisit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCheckVisit.UseVisualStyleBackColor = true;
            this.BtnCheckVisit.Click += new System.EventHandler(this.BtnCheckVisit_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(247, 42);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(62, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Плата:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата посещения:";
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 467);
            this.Controls.Add(this.pCheck);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(715, 505);
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет посещения тренировок";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pCheck.ResumeLayout(false);
            this.pCheck.PerformLayout();
            this.pSubscription.ResumeLayout(false);
            this.pSubscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpVisit;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pCheck;
        private System.Windows.Forms.Button BtnCheckVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Panel pSubscription;
        private System.Windows.Forms.TextBox txbSubscriptionCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MPK_Calendar.MPK_Calendar mcVisitation;
        private System.Windows.Forms.Button BtnRemoveAttendance;
    }
}