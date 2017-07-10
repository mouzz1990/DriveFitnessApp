namespace DriveFitnessApp
{
    partial class DriveFitness
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
            this.BtnAttendance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSubscription = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddNewClient = new System.Windows.Forms.Button();
            this.BtnChangeClientInfo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnGroupManage = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAttendance
            // 
            this.BtnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAttendance.Location = new System.Drawing.Point(9, 9);
            this.BtnAttendance.Name = "BtnAttendance";
            this.BtnAttendance.Size = new System.Drawing.Size(400, 40);
            this.BtnAttendance.TabIndex = 0;
            this.BtnAttendance.Text = "Учет посещаемости клиентов";
            this.BtnAttendance.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAttendance);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnSubscription);
            this.panel2.Location = new System.Drawing.Point(12, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 60);
            this.panel2.TabIndex = 2;
            // 
            // BtnSubscription
            // 
            this.BtnSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSubscription.Location = new System.Drawing.Point(9, 10);
            this.BtnSubscription.Name = "BtnSubscription";
            this.BtnSubscription.Size = new System.Drawing.Size(400, 40);
            this.BtnSubscription.TabIndex = 1;
            this.BtnSubscription.Text = "Работа с абонементами";
            this.BtnSubscription.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnChangeClientInfo);
            this.panel3.Controls.Add(this.BtnAddNewClient);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 173);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа с клиентами";
            // 
            // BtnAddNewClient
            // 
            this.BtnAddNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddNewClient.Location = new System.Drawing.Point(9, 43);
            this.BtnAddNewClient.Name = "BtnAddNewClient";
            this.BtnAddNewClient.Size = new System.Drawing.Size(400, 40);
            this.BtnAddNewClient.TabIndex = 1;
            this.BtnAddNewClient.Text = "Добавить нового клиента";
            this.BtnAddNewClient.UseVisualStyleBackColor = true;
            this.BtnAddNewClient.Click += new System.EventHandler(this.BtnAddNewClient_Click);
            // 
            // BtnChangeClientInfo
            // 
            this.BtnChangeClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChangeClientInfo.Location = new System.Drawing.Point(9, 89);
            this.BtnChangeClientInfo.Name = "BtnChangeClientInfo";
            this.BtnChangeClientInfo.Size = new System.Drawing.Size(400, 72);
            this.BtnChangeClientInfo.TabIndex = 2;
            this.BtnChangeClientInfo.Text = "Изменить информацию о клиенте";
            this.BtnChangeClientInfo.UseVisualStyleBackColor = true;
            this.BtnChangeClientInfo.Click += new System.EventHandler(this.BtnChangeClientInfo_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BtnGroupManage);
            this.panel4.Location = new System.Drawing.Point(12, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 60);
            this.panel4.TabIndex = 4;
            // 
            // BtnGroupManage
            // 
            this.BtnGroupManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGroupManage.Location = new System.Drawing.Point(10, 9);
            this.BtnGroupManage.Name = "BtnGroupManage";
            this.BtnGroupManage.Size = new System.Drawing.Size(400, 40);
            this.BtnGroupManage.TabIndex = 0;
            this.BtnGroupManage.Text = "Работа с группами";
            this.BtnGroupManage.UseVisualStyleBackColor = true;
            // 
            // BtnReport
            // 
            this.BtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReport.Location = new System.Drawing.Point(11, 9);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(400, 40);
            this.BtnReport.TabIndex = 5;
            this.BtnReport.Text = "Финансовый отчет";
            this.BtnReport.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.BtnReport);
            this.panel5.Location = new System.Drawing.Point(12, 422);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 60);
            this.panel5.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // DriveFitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 494);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DriveFitness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriveFitness";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSubscription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnChangeClientInfo;
        private System.Windows.Forms.Button BtnAddNewClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnGroupManage;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;

    }
}