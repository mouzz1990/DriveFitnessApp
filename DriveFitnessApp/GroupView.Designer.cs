namespace DriveFitnessApp
{
    partial class GroupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupView));
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.pEdit = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEdit = new System.Windows.Forms.TextBox();
            this.pAdd = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.pGroups = new System.Windows.Forms.Panel();
            this.pEdit.SuspendLayout();
            this.pAdd.SuspendLayout();
            this.pGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGroups
            // 
            this.lbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 20;
            this.lbGroups.Location = new System.Drawing.Point(11, 39);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(238, 364);
            this.lbGroups.TabIndex = 0;
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группы:";
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEdit.Location = new System.Drawing.Point(509, 12);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(207, 24);
            this.rbEdit.TabIndex = 2;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "Изменить информацию";
            this.rbEdit.UseVisualStyleBackColor = true;
            this.rbEdit.CheckedChanged += new System.EventHandler(this.rbEdit_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAdd.Location = new System.Drawing.Point(291, 12);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(204, 24);
            this.rbAdd.TabIndex = 3;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Добавить новую группу";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // pEdit
            // 
            this.pEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEdit.Controls.Add(this.BtnDelete);
            this.pEdit.Controls.Add(this.BtnChange);
            this.pEdit.Controls.Add(this.label2);
            this.pEdit.Controls.Add(this.txbEdit);
            this.pEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pEdit.Location = new System.Drawing.Point(290, 45);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(426, 125);
            this.pEdit.TabIndex = 4;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.Image = global::DriveFitnessApp.Properties.Resources.GroupsDelete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(18, 71);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(146, 37);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.Image = global::DriveFitnessApp.Properties.Resources.GroupsEdit;
            this.BtnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChange.Location = new System.Drawing.Point(257, 71);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(153, 37);
            this.BtnChange.TabIndex = 2;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изменить информацию о группе:";
            // 
            // txbEdit
            // 
            this.txbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbEdit.Location = new System.Drawing.Point(18, 39);
            this.txbEdit.Name = "txbEdit";
            this.txbEdit.Size = new System.Drawing.Size(392, 26);
            this.txbEdit.TabIndex = 0;
            // 
            // pAdd
            // 
            this.pAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAdd.Controls.Add(this.BtnAdd);
            this.pAdd.Controls.Add(this.label3);
            this.pAdd.Controls.Add(this.txbAdd);
            this.pAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pAdd.Location = new System.Drawing.Point(290, 174);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(426, 125);
            this.pAdd.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Image = global::DriveFitnessApp.Properties.Resources.GroupsAdd;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(132, 69);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(161, 37);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Добавить новую группу:";
            // 
            // txbAdd
            // 
            this.txbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbAdd.Location = new System.Drawing.Point(18, 37);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(392, 26);
            this.txbAdd.TabIndex = 0;
            // 
            // pGroups
            // 
            this.pGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGroups.Controls.Add(this.label1);
            this.pGroups.Controls.Add(this.lbGroups);
            this.pGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pGroups.Location = new System.Drawing.Point(12, 15);
            this.pGroups.Name = "pGroups";
            this.pGroups.Size = new System.Drawing.Size(260, 424);
            this.pGroups.TabIndex = 6;
            // 
            // GroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.pGroups);
            this.Controls.Add(this.pAdd);
            this.Controls.Add(this.pEdit);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.rbEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с группами";
            this.Load += new System.EventHandler(this.GroupView_Load);
            this.pEdit.ResumeLayout(false);
            this.pEdit.PerformLayout();
            this.pAdd.ResumeLayout(false);
            this.pAdd.PerformLayout();
            this.pGroups.ResumeLayout(false);
            this.pGroups.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEdit;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Panel pEdit;
        private System.Windows.Forms.TextBox txbEdit;
        private System.Windows.Forms.Panel pAdd;
        private System.Windows.Forms.TextBox txbAdd;
        private System.Windows.Forms.Panel pGroups;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
    }
}