namespace DriveFitnessApp
{
    partial class ScheduleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.BtnAddNewSchedule = new System.Windows.Forms.Button();
            this.pAdd = new System.Windows.Forms.Panel();
            this.rbAddNew = new System.Windows.Forms.RadioButton();
            this.rbChange = new System.Windows.Forms.RadioButton();
            this.txbDay = new System.Windows.Forms.TextBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnChangeInfo = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSchedule);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbGroup);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 399);
            this.panel1.TabIndex = 0;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(91, 22);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(225, 28);
            this.cmbGroup.TabIndex = 0;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа:";
            // 
            // lbSchedule
            // 
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.ItemHeight = 20;
            this.lbSchedule.Location = new System.Drawing.Point(8, 58);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(308, 324);
            this.lbSchedule.TabIndex = 2;
            this.lbSchedule.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // BtnAddNewSchedule
            // 
            this.BtnAddNewSchedule.Location = new System.Drawing.Point(183, 110);
            this.BtnAddNewSchedule.Name = "BtnAddNewSchedule";
            this.BtnAddNewSchedule.Size = new System.Drawing.Size(176, 37);
            this.BtnAddNewSchedule.TabIndex = 3;
            this.BtnAddNewSchedule.Text = "Добавить запись";
            this.BtnAddNewSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewSchedule.UseVisualStyleBackColor = true;
            this.BtnAddNewSchedule.Click += new System.EventHandler(this.BtnAddNewSchedule_Click);
            // 
            // pAdd
            // 
            this.pAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdd.Controls.Add(this.BtnRemove);
            this.pAdd.Controls.Add(this.BtnChangeInfo);
            this.pAdd.Controls.Add(this.label3);
            this.pAdd.Controls.Add(this.label2);
            this.pAdd.Controls.Add(this.txbTime);
            this.pAdd.Controls.Add(this.txbDay);
            this.pAdd.Controls.Add(this.BtnAddNewSchedule);
            this.pAdd.Location = new System.Drawing.Point(352, 44);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(381, 169);
            this.pAdd.TabIndex = 4;
            // 
            // rbAddNew
            // 
            this.rbAddNew.AutoSize = true;
            this.rbAddNew.Checked = true;
            this.rbAddNew.Location = new System.Drawing.Point(352, 14);
            this.rbAddNew.Name = "rbAddNew";
            this.rbAddNew.Size = new System.Drawing.Size(208, 24);
            this.rbAddNew.TabIndex = 5;
            this.rbAddNew.TabStop = true;
            this.rbAddNew.Text = "Добавить новую запись";
            this.rbAddNew.UseVisualStyleBackColor = true;
            this.rbAddNew.CheckedChanged += new System.EventHandler(this.rbAddNew_CheckedChanged);
            // 
            // rbChange
            // 
            this.rbChange.AutoSize = true;
            this.rbChange.Location = new System.Drawing.Point(575, 14);
            this.rbChange.Name = "rbChange";
            this.rbChange.Size = new System.Drawing.Size(158, 24);
            this.rbChange.TabIndex = 6;
            this.rbChange.Text = "Изменить запись";
            this.rbChange.UseVisualStyleBackColor = true;
            this.rbChange.CheckedChanged += new System.EventHandler(this.rbChange_CheckedChanged);
            // 
            // txbDay
            // 
            this.txbDay.Location = new System.Drawing.Point(88, 17);
            this.txbDay.Name = "txbDay";
            this.txbDay.Size = new System.Drawing.Size(271, 26);
            this.txbDay.TabIndex = 4;
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(88, 64);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(271, 26);
            this.txbTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "День:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время:";
            // 
            // BtnChangeInfo
            // 
            this.BtnChangeInfo.Location = new System.Drawing.Point(183, 110);
            this.BtnChangeInfo.Name = "BtnChangeInfo";
            this.BtnChangeInfo.Size = new System.Drawing.Size(176, 37);
            this.BtnChangeInfo.TabIndex = 7;
            this.BtnChangeInfo.Text = "Изменить данные";
            this.BtnChangeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChangeInfo.UseVisualStyleBackColor = true;
            this.BtnChangeInfo.Click += new System.EventHandler(this.BtnChangeInfo_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(6, 110);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(160, 37);
            this.BtnRemove.TabIndex = 8;
            this.BtnRemove.Text = "Удалить запись";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 425);
            this.Controls.Add(this.rbChange);
            this.Controls.Add(this.rbAddNew);
            this.Controls.Add(this.pAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pAdd.ResumeLayout(false);
            this.pAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.Button BtnAddNewSchedule;
        private System.Windows.Forms.Panel pAdd;
        private System.Windows.Forms.RadioButton rbAddNew;
        private System.Windows.Forms.RadioButton rbChange;
        private System.Windows.Forms.Button BtnChangeInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbDay;
        private System.Windows.Forms.Button BtnRemove;
    }
}