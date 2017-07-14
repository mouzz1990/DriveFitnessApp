using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary;

namespace DriveFitnessApp
{
    public partial class AttendanceForm : Form, IAttendanceView
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        //public Client Client
        //{
        //    get { return (Client)lbClients.SelectedItem; }
        //}

        public DateTime DateVisit
        {
            get { return dtpVisit.Value; }
        }

        public float Price
        {
            get 
            { 
                if (numPrice.Visible)
                    return (float)numPrice.Value;

                return 0;
            }
        }

        public event EventHandler VisitationChecked;
        public event EventHandler FormLoaded;

        public Client GetClient()
        {
            Client client = (Client)lbClients.SelectedItem;
            return client;
        }

        private void BtnCheckVisit_Click(object sender, EventArgs e)
        {
            if (VisitationChecked != null)
                VisitationChecked(this, EventArgs.Empty);

            pgClientInfo.Refresh();
        }

        public void DisplayGroups(List<Group> group)
        {
            cmbGroup.Items.Clear();

            foreach (var g in group)
                cmbGroup.Items.Add(g);

            if (cmbGroup.Items.Count > 0) cmbGroup.SelectedIndex = 0;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            lbPrice.Visible = false;
            numPrice.Visible = false;

            if (FormLoaded != null)
                FormLoaded(this, EventArgs.Empty);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbClients.Items.Clear();

            foreach (var c in ((Group)cmbGroup.SelectedItem).ClientsList)
                lbClients.Items.Add(c);
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClients.SelectedIndex < 0) return;
            
            Client client = (Client)lbClients.SelectedItem;

            pgClientInfo.SelectedObject = client;

            if (client.Subscription != null)
            {
                numPrice.Visible = false;
                lbPrice.Visible = false;
            }
            else
            {
                numPrice.Visible = true;
                lbPrice.Visible = true;
            }
            
        }
    }
}
