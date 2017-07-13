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
    public partial class AddNewClient : Form, IClientView
    {
        public AddNewClient()
        {
            InitializeComponent();
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

        public void OnGroupsRequred()
        {
            if (GroupsRequred != null)
                GroupsRequred(this, EventArgs.Empty);
        }

        public void DisplayGroups(List<Group> groupList)
        {
            foreach (var g in groupList)
                cmbGroup.Items.Add(g);
        }

        public event EventHandler AddClientClicked;
        public event EventHandler GroupsRequred;
        public event EventHandler ClientInformationChanged;
        public event EventHandler ClientDeleted;
        public event EventHandler CreateClientCard;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (AddClientClicked != null)
                AddClientClicked(sender, e);
        }

        private void AddNewClient_Load(object sender, EventArgs e)
        {
            OnGroupsRequred();

            if (cmbGroup.Items.Count != 0)
                cmbGroup.SelectedIndex = 0;
        }

        public void RefreshForm()
        {
            foreach (Control ctr in panel1.Controls)
            {
                TextBox tx = ctr as TextBox;
                if (tx != null)
                    tx.Text = string.Empty;
            }

            dtpBirthday.Value = DateTime.Today;
        }

        public Group ClientGroup
        {
            get
            {
                return Group;
            }
        }

        public event EventHandler GroupChanged;
        public void SelectGroup(Group group)
        {
            return;
        }
    }
}
