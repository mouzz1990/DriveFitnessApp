using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary;
using MPK_Calendar;

namespace DriveFitnessApp
{
    public partial class AttendanceForm : Form, IAttendanceView
    {
        public AttendanceForm()
        {
            InitializeComponent();
            pSubscription.Visible = false;
            dtpVisit.Enabled = false;
            pCheck.Visible = false;
        }
        
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
        public event EventHandler ClientChanged;
        public event EventHandler VisitationDeleted;

        public Client GetClient()
        {
            Client client = (Client)lbClients.SelectedItem;
            return client;
        }

        private void BtnCheckVisit_Click(object sender, EventArgs e)
        {
            if (VisitationChecked != null)
                VisitationChecked(this, EventArgs.Empty);

            if (ClientChanged != null) ClientChanged(this, EventArgs.Empty);
            //pgClientInfo.Refresh();
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
            lbPrice.Enabled = false;
            numPrice.Enabled = false;

            if (FormLoaded != null)
                FormLoaded(this, EventArgs.Empty);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbClients.Items.Clear();
            pCheck.Visible = false;
            foreach (var c in ((Group)cmbGroup.SelectedItem).ClientsList)
                lbClients.Items.Add(c);
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClients.SelectedIndex < 0)
            {
                pCheck.Visible = false;
                return;
            }

            pCheck.Visible = true;
            Client client = (Client)lbClients.SelectedItem;

            DisplayClientInformatio(client);

            if (ClientChanged != null) ClientChanged(this, EventArgs.Empty);

            //pgClientInfo.SelectedObject = client;

            if (client.Subscription != null)
            {
                numPrice.Enabled = false;
                lbPrice.Enabled = false;
            }
            else
            {
                numPrice.Enabled = true;
                lbPrice.Enabled = true;
            }
        }

        void DisplayClientInformatio(Client client)
        {
            if (client.Subscription != null)
            {
                pSubscription.Visible = true;
                txbSubscriptionCount.Text = client.Subscription.CountTraining.ToString();
            }
            else
            {
                pSubscription.Visible = false;
            }
        }

        public void DisplayVisitedDates(List<DateTime> datesVisitation)
        {
            mcVisitation.BoldedDates = datesVisitation.ToArray();

            //mcVisitation.Update();
            mcVisitation.Visible = false;
            mcVisitation.Visible = true;
        }

        private void mcVisitation_SelectedDateChanged(object sender, SelectedDateChangedEventArgs e)
        {
            dtpVisit.Value = mcVisitation.SelectedDate;
        }

        private void dtpVisit_ValueChanged(object sender, EventArgs e)
        {
            mcVisitation.SelectedDate = dtpVisit.Value;
        }

        private void BtnRemoveAttendance_Click(object sender, EventArgs e)
        {
            if (VisitationDeleted != null)
                VisitationDeleted(this, EventArgs.Empty);

            if (ClientChanged != null) ClientChanged(this, EventArgs.Empty);
        }
    }
}
