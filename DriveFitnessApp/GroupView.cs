using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            pAdd.Visible = false;
            pEdit.Visible = true;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            pAdd.Visible = true;
            pEdit.Visible = false;
        }

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

        public event EventHandler AddNewGroup;
        public event EventHandler ChangeGroup;
        public event EventHandler RemoveGroup;
        public event EventHandler RefreshGroupList;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (AddNewGroup != null)
                AddNewGroup(this, EventArgs.Empty);
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (ChangeGroup != null)
                ChangeGroup(this, EventArgs.Empty);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (RemoveGroup != null)
                    RemoveGroup(this, EventArgs.Empty);
            }
            catch (RemoveGroupException rge)
            {
                DialogResult dr = MessageBox.Show(
                    string.Format("{0}{1}{1}{2}",
                    rge.MessageRemoveGroupException, 
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
                    ClientManager clm = new ClientManager(dbm, mess);
                    GroupManager gm = new GroupManager(dbm, mess);
                    ChangeClientInfo chClient = new ChangeClientInfo();

                    ClientPresenter clPress = new ClientPresenter(chClient, clm, gm, mess);

                    chClient.SelectGroup((Group)lbGroups.SelectedItem);
                    chClient.ShowDialog();
                    
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
            if (lbGroups.SelectedIndex < 0) return;

            txbEdit.Text = ((Group)lbGroups.SelectedItem).GroupName;
        }

    }
}
