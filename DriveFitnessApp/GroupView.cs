﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary;
using DriveFitnessLibrary.Presenters;
using DriveFitnessLibrary.Managers;

namespace DriveFitnessApp
{
    public partial class GroupView : Form, IGroupView
    {
        public GroupView()
        {
            InitializeComponent();
            rbAdd.Checked = true;
            pAdd.Location = new Point(290,45);
            pEdit.Visible = false;
        }

        public event EventHandler AddNewGroup;
        public event EventHandler ChangeGroup;
        public event EventHandler RemoveGroup;
        public event EventHandler RefreshGroupList;
        
        public Group Group
        {
            get { return (Group)lbGroups.SelectedItem; }
        }

        public string NewGroupName
        {
            get { return txbAdd.Text; }
        }

        public string EditedGroupName
        {
            get { return txbEdit.Text; }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (AddNewGroup != null)
                AddNewGroup(this, EventArgs.Empty);

            txbAdd.Text = string.Empty;
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (ChangeGroup != null)
                ChangeGroup(this, EventArgs.Empty);

            pEdit.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (RemoveGroup != null)
                    RemoveGroup(this, EventArgs.Empty);

                txbEdit.Text = string.Empty;
                pEdit.Visible = false;
            }
            catch (RemoveGroupException rge)
            {
                DialogResult dr = MessageBox.Show(
                    string.Format("{0}{1}{1}{2}",
                    rge, 
                    Environment.NewLine,
                    "Открыть форму работы с клиентами?"),
                    "Ошибка удаления группы",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    MySqlManager dbm = new MySqlManager();
                    Messager mess = new Messager();
                    ClientCardCreatorManager clientCardCreator = new ClientCardCreatorManager();
                    ClientManager clm = new ClientManager(dbm, mess);
                    GroupManager gm = new GroupManager(dbm, mess);
                    ChangeClientInfo chClient = new ChangeClientInfo((Group)lbGroups.SelectedItem);

                    ClientPresenter clPress = new ClientPresenter(chClient, clm, gm, clientCardCreator, mess);

                    int grInx = lbGroups.SelectedIndex;
                    DialogResult clientFormClosedResult = chClient.ShowDialog();

                    if (clientFormClosedResult == System.Windows.Forms.DialogResult.OK)
                    {
                        if (RefreshGroupList != null)
                            RefreshGroupList(this, EventArgs.Empty);

                        lbGroups.SelectedIndex = grInx;
                    }
                    
                }
            }
        }

        public void RefreshGroupsList(List<Group> groupList)
        {
            lbGroups.Items.Clear();

            foreach (var g in groupList)
                lbGroups.Items.Add(g);
        }

        private void GroupView_Load(object sender, EventArgs e)
        {
            if (RefreshGroupList != null)
                RefreshGroupList(this, EventArgs.Empty);
        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGroups.SelectedIndex < 0)
            {
                pEdit.Visible = false;
                return;
            }

            pEdit.Visible = true;
            txbEdit.Text = ((Group)lbGroups.SelectedItem).GroupName;
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            pAdd.Visible = false;
            lbGroups.Enabled = true;

            if (lbGroups.SelectedIndex < 0)
                pEdit.Visible = false;

            else pEdit.Visible = true;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            pAdd.Visible = true;

            lbGroups.Enabled = false;

            if (lbGroups.SelectedIndex < 0)
                pEdit.Visible = false;

            else pEdit.Visible = true;
        }

    }
}
