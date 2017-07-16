namespace DriveFitnessApp
{
    partial class SubscriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriptionForm));
            this.pGroups = new System.Windows.Forms.Panel();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.pSubAdd = new System.Windows.Forms.Panel();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.txbNewPrice = new System.Windows.Forms.TextBox();
            this.txbNewCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pSubInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSubDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSubPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbSubCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.pGroups.SuspendLayout();
            this.pSubAdd.SuspendLayout();
            this.pSubInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGroups
            // 
            this.pGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGroups.Controls.Add(this.lbClients);
            this.pGroups.Controls.Add(this.label1);
            this.pGroups.Controls.Add(this.cmbGroups);
            this.pGroups.Location = new System.Drawing.Point(12, 12);
            this.pGroups.Name = "pGroups";
            this.pGroups.Size = new System.Drawing.Size(270, 458);
            this.pGroups.TabIndex = 0;
            // 
            // lbClients
            // 
            this.lbClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 20;
            this.lbClients.Location = new System.Drawing.Point(18, 50);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(240, 384);
            this.lbClients.TabIndex = 1;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа:";
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(85, 16);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(173, 28);
            this.cmbGroups.TabIndex = 0;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // pSubAdd
            // 
            this.pSubAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSubAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSubAdd.Controls.Add(this.BtnAdd);
            this.pSubAdd.Controls.Add(this.dtpNewDate);
            this.pSubAdd.Controls.Add(this.txbNewPrice);
            this.pSubAdd.Controls.Add(this.txbNewCount);
            this.pSubAdd.Controls.Add(this.label6);
            this.pSubAdd.Controls.Add(this.label5);
            this.pSubAdd.Controls.Add(this.label4);
            this.pSubAdd.Controls.Add(this.label2);
            this.pSubAdd.Location = new System.Drawing.Point(288, 12);
            this.pSubAdd.Name = "pSubAdd";
            this.pSubAdd.Size = new System.Drawing.Size(404, 247);
            this.pSubAdd.TabIndex = 1;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNewDate.Location = new System.Drawing.Point(162, 146);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(232, 26);
            this.dtpNewDate.TabIndex = 4;
            // 
            // txbNewPrice
            // 
            this.txbNewPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNewPrice.Location = new System.Drawing.Point(162, 99);
            this.txbNewPrice.Name = "txbNewPrice";
            this.txbNewPrice.Size = new System.Drawing.Size(232, 26);
            this.txbNewPrice.TabIndex = 3;
            // 
            // txbNewCount
            // 
            this.txbNewCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNewCount.Location = new System.Drawing.Point(162, 60);
            this.txbNewCount.Name = "txbNewCount";
            this.txbNewCount.Size = new System.Drawing.Size(232, 26);
            this.txbNewCount.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Дата покупки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Стоимость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Кол-во занятий:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Оформить абонемент";
            // 
            // pSubInfo
            // 
            this.pSubInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSubInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSubInfo.Controls.Add(this.BtnClose);
            this.pSubInfo.Controls.Add(this.BtnChange);
            this.pSubInfo.Controls.Add(this.label3);
            this.pSubInfo.Controls.Add(this.dtpSubDate);
            this.pSubInfo.Controls.Add(this.label7);
            this.pSubInfo.Controls.Add(this.txbSubPrice);
            this.pSubInfo.Controls.Add(this.label8);
            this.pSubInfo.Controls.Add(this.txbSubCount);
            this.pSubInfo.Controls.Add(this.label9);
            this.pSubInfo.Location = new System.Drawing.Point(288, 265);
            this.pSubInfo.Name = "pSubInfo";
            this.pSubInfo.Size = new System.Drawing.Size(404, 205);
            this.pSubInfo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Информация об абонементе";
            // 
            // dtpSubDate
            // 
            this.dtpSubDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSubDate.Location = new System.Drawing.Point(162, 118);
            this.dtpSubDate.Name = "dtpSubDate";
            this.dtpSubDate.Size = new System.Drawing.Size(232, 26);
            this.dtpSubDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Кол-во занятий:";
            // 
            // txbSubPrice
            // 
            this.txbSubPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSubPrice.Location = new System.Drawing.Point(162, 83);
            this.txbSubPrice.Name = "txbSubPrice";
            this.txbSubPrice.Size = new System.Drawing.Size(232, 26);
            this.txbSubPrice.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Стоимость:";
            // 
            // txbSubCount
            // 
            this.txbSubCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSubCount.Location = new System.Drawing.Point(162, 48);
            this.txbSubCount.Name = "txbSubCount";
            this.txbSubCount.Size = new System.Drawing.Size(232, 26);
            this.txbSubCount.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Дата покупки:";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Image = global::DriveFitnessApp.Properties.Resources.SubscriptionClose;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(7, 150);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(128, 45);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.Image = global::DriveFitnessApp.Properties.Resources.SubscriptionChange;
            this.BtnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChange.Location = new System.Drawing.Point(256, 150);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(138, 45);
            this.BtnChange.TabIndex = 5;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Image = global::DriveFitnessApp.Properties.Resources.SubscriptionAdd;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(78, 188);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(246, 45);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Оформить абонемент";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 486);
            this.Controls.Add(this.pSubInfo);
            this.Controls.Add(this.pSubAdd);
            this.Controls.Add(this.pGroups);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(723, 524);
            this.Name = "SubscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абонементы";
            this.Load += new System.EventHandler(this.SubscriptionForm_Load);
            this.pGroups.ResumeLayout(false);
            this.pGroups.PerformLayout();
            this.pSubAdd.ResumeLayout(false);
            this.pSubAdd.PerformLayout();
            this.pSubInfo.ResumeLayout(false);
            this.pSubInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGroups;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Panel pSubAdd;
        private System.Windows.Forms.Panel pSubInfo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.TextBox txbNewPrice;
        private System.Windows.Forms.TextBox txbNewCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSubDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSubPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbSubCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnChange;
    }
}