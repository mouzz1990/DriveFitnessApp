namespace DriveFitnessApp
{
    partial class MessageSenderForm
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
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSnd = new System.Windows.Forms.Button();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pSend = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.clbClients = new System.Windows.Forms.CheckedListBox();
            this.BtnCheckAll = new System.Windows.Forms.Button();
            this.pSend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbLogin
            // 
            this.txbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLogin.Location = new System.Drawing.Point(108, 10);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(246, 26);
            this.txbLogin.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.Location = new System.Drawing.Point(108, 42);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(246, 26);
            this.txbPassword.TabIndex = 3;
            // 
            // txbMessage
            // 
            this.txbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMessage.Location = new System.Drawing.Point(14, 173);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(340, 195);
            this.txbMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // BtnSnd
            // 
            this.BtnSnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSnd.Location = new System.Drawing.Point(99, 374);
            this.BtnSnd.Name = "BtnSnd";
            this.BtnSnd.Size = new System.Drawing.Size(190, 41);
            this.BtnSnd.TabIndex = 6;
            this.BtnSnd.Text = "Отправить сообщение";
            this.BtnSnd.UseVisualStyleBackColor = true;
            this.BtnSnd.Click += new System.EventHandler(this.BtnSnd_Click);
            // 
            // txbSubject
            // 
            this.txbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSubject.Location = new System.Drawing.Point(14, 111);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(340, 26);
            this.txbSubject.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тема сообщения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сообщение:";
            // 
            // pSend
            // 
            this.pSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSend.Controls.Add(this.label1);
            this.pSend.Controls.Add(this.txbSubject);
            this.pSend.Controls.Add(this.txbLogin);
            this.pSend.Controls.Add(this.BtnSnd);
            this.pSend.Controls.Add(this.txbPassword);
            this.pSend.Controls.Add(this.label4);
            this.pSend.Controls.Add(this.txbMessage);
            this.pSend.Controls.Add(this.label3);
            this.pSend.Controls.Add(this.label2);
            this.pSend.Location = new System.Drawing.Point(314, 12);
            this.pSend.Name = "pSend";
            this.pSend.Size = new System.Drawing.Size(366, 424);
            this.pSend.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCheckAll);
            this.panel1.Controls.Add(this.cmbGroup);
            this.panel1.Controls.Add(this.clbClients);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 424);
            this.panel1.TabIndex = 7;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(3, 10);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(290, 28);
            this.cmbGroup.TabIndex = 0;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // clbClients
            // 
            this.clbClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.clbClients.CheckOnClick = true;
            this.clbClients.FormattingEnabled = true;
            this.clbClients.Location = new System.Drawing.Point(3, 54);
            this.clbClients.Name = "clbClients";
            this.clbClients.Size = new System.Drawing.Size(290, 319);
            this.clbClients.TabIndex = 1;
            // 
            // BtnCheckAll
            // 
            this.BtnCheckAll.Location = new System.Drawing.Point(3, 379);
            this.BtnCheckAll.Name = "BtnCheckAll";
            this.BtnCheckAll.Size = new System.Drawing.Size(288, 40);
            this.BtnCheckAll.TabIndex = 2;
            this.BtnCheckAll.Text = "Выбрать всех";
            this.BtnCheckAll.UseVisualStyleBackColor = true;
            this.BtnCheckAll.Click += new System.EventHandler(this.BtnCheckAll_Click);
            // 
            // MessageSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(707, 485);
            this.Name = "MessageSenderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка сообщений клиентам";
            this.Load += new System.EventHandler(this.MessageSenderForm_Load);
            this.pSend.ResumeLayout(false);
            this.pSend.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSnd;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.CheckedListBox clbClients;
        private System.Windows.Forms.Button BtnCheckAll;
    }
}