﻿namespace DriveFitnessApp
{
    partial class ChangeClientInfo
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
            this.cmbClientGroup = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.BtnChangeInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cmbClientGroup);
            this.panel1.Controls.Add(this.dtpBirthday);
            this.panel1.Controls.Add(this.BtnChangeInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTelephone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbLastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(375, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 415);
            this.panel1.TabIndex = 6;
            // 
            // cmbClientGroup
            // 
            this.cmbClientGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbClientGroup.FormattingEnabled = true;
            this.cmbClientGroup.Location = new System.Drawing.Point(151, 188);
            this.cmbClientGroup.Name = "cmbClientGroup";
            this.cmbClientGroup.Size = new System.Drawing.Size(301, 28);
            this.cmbClientGroup.TabIndex = 7;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Location = new System.Drawing.Point(151, 83);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(301, 26);
            this.dtpBirthday.TabIndex = 6;
            // 
            // BtnChangeInfo
            // 
            this.BtnChangeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChangeInfo.Location = new System.Drawing.Point(101, 239);
            this.BtnChangeInfo.Name = "BtnChangeInfo";
            this.BtnChangeInfo.Size = new System.Drawing.Size(351, 52);
            this.BtnChangeInfo.TabIndex = 5;
            this.BtnChangeInfo.Text = "Изменить информацию о клиенте";
            this.BtnChangeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChangeInfo.UseVisualStyleBackColor = true;
            this.BtnChangeInfo.Click += new System.EventHandler(this.BtnChangeInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:*";
            // 
            // txbTelephone
            // 
            this.txbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTelephone.Location = new System.Drawing.Point(151, 153);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(301, 26);
            this.txbTelephone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя:*";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbEmail.Location = new System.Drawing.Point(151, 118);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(301, 26);
            this.txbEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата рождения:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbName.Location = new System.Drawing.Point(151, 48);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(301, 26);
            this.txbName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbLastName.Location = new System.Drawing.Point(151, 13);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(301, 26);
            this.txbLastName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(58, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Телефон:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(82, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Группа:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbClients);
            this.panel2.Controls.Add(this.cmbGroup);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 415);
            this.panel2.TabIndex = 7;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(83, 14);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(262, 28);
            this.cmbGroup.TabIndex = 0;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Группа:";
            // 
            // lbClients
            // 
            this.lbClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 20;
            this.lbClients.Location = new System.Drawing.Point(16, 52);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(329, 344);
            this.lbClients.TabIndex = 1;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRemove.Location = new System.Drawing.Point(3, 3);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(193, 52);
            this.BtnRemove.TabIndex = 5;
            this.BtnRemove.Text = "Удалить запись";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnRemove);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(250, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 61);
            this.panel3.TabIndex = 8;
            // 
            // ChangeClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeClientInfo";
            this.Load += new System.EventHandler(this.ChangeClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClientGroup;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnChangeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
    }
}