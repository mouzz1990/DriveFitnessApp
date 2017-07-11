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

namespace DriveFitnessApp
{
    public partial class ChangeClientInfo : Form, IClientView
    {
        public ChangeClientInfo()
        {
            InitializeComponent();
        }

        public ChangeClientInfo(Group selectedGroup)
        {
            InitializeComponent();
            selectedGr = selectedGroup;
        }

        Group selectedGr;

        private void ChangeClientInfo_Load(object sender, EventArgs e)
        {
            OnGroupsRequred();

            if (cmbGroup.Items.Count > 0)
            {
                if (selectedGr != null) cmbGroup.SelectedItem = selectedGr;
                else cmbGroup.SelectedIndex = 0;
            }
        }

        public string NameClient
        {
            get { return txbName.Text; }
        }

        public string LastNameClient
        {
            get { return txbLastName.Text; }
        }

        public DateTime Birthday
        {
            get { return dtpBirthday.Value; }
        }

        public string Email
        {
            get { return txbEmail.Text; }
        }

        public string Telephone
        {
            get { return txbTelephone.Text; }
        }

        public Group Group
        {
            get { return (Group)cmbGroup.SelectedItem; }
        }

        public Group ClientGroup
        {
            get { return (Group)cmbClientGroup.SelectedItem; }
        }

        public void OnGroupsRequred()
        {
            if (GroupsRequred != null)
                GroupsRequred(this, EventArgs.Empty);
        }

        public void DisplayGroups(List<Group> groupList)
        {
            cmbGroup.Items.Clear();
            cmbClientGroup.Items.Clear();

            foreach (var g in groupList)
            {
                cmbGroup.Items.Add(g);
                cmbClientGroup.Items.Add(g);
            }
        }

        public void RefreshForm()
        {
            lbClients.Items.Clear();

            foreach (var c in Group.ClientsList)
                lbClients.Items.Add(c);
        }

        public event EventHandler AddClientClicked;
        public event EventHandler GroupsRequred;
        public event EventHandler ClientInformationChanged;
        public event EventHandler ClientDeleted;
        public event EventHandler GroupChanged;

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupChanged != null)
                GroupChanged(this, EventArgs.Empty);
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClients.SelectedIndex < 0)
                return;
            
            Client selectedClient = (Client)lbClients.SelectedItem;

            txbLastName.Text = selectedClient.LastName;
            txbName.Text = selectedClient.Name;
            dtpBirthday.Value = selectedClient.Birthday;
            txbEmail.Text = selectedClient.Email;
            txbTelephone.Text = selectedClient.Telephone;
            cmbClientGroup.SelectedItem = cmbGroup.SelectedItem;
        }

        private void BtnChangeInfo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите изменить информацию о клиенте?",
                "Изменение информации о клиенте",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ClientEventArgs cEvArg = new ClientEventArgs((Client)lbClients.SelectedItem);

                if (ClientInformationChanged != null)
                    ClientInformationChanged(this, cEvArg);
            }
        }

        public void SelectGroup(Group group)
        {
            cmbGroup.SelectedItem = group;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Информация о клиенте будет безвозвратно удалено, вы действительно хотите продолжить?", 
                "Удаление клиента из БД", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Asterisk);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ClientEventArgs clEvArg = new ClientEventArgs((Client)lbClients.SelectedItem);

                if (ClientDeleted != null)
                    ClientDeleted(this, clEvArg);
            }
        }
    }
}
