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
    public partial class SubscriptionForm : Form, ISubscriptionView
    {
        public SubscriptionForm()
        {
            InitializeComponent();

            pSubInfo.Location = new Point(288, 12);
            pSubInfo.Visible = false;
            pSubAdd.Visible = false;
        }

        public int NewSubscriptionCount
        {
            get 
            {
                int temp;
                if (int.TryParse(txbNewCount.Text, out temp))
                    return temp;
                
                else return 0;
            }
        }

        public float NewSubscriptionPrice
        {
            get 
            {
                string val = txbNewPrice.Text.Replace('.',',');
                float temp;
                if (float.TryParse(val, out temp))
                    return temp;

                else return 0;
            }
        }

        public DateTime NewSubscriptionDate
        {
            get { return dtpNewDate.Value; }
        }

        public DriveFitnessLibrary.Client Client
        {
            get { return (Client)lbClients.SelectedItem; }
        }

        public event EventHandler AddNewSubscription;
        public new event EventHandler Refresh;
        
        private void SubscriptionForm_Load(object sender, EventArgs e)
        {
            if (Refresh != null)
                Refresh(this, EventArgs.Empty);
        }

        public void RefreshForm(List<Group> groups)
        {
            int selIndGroup = cmbGroups.SelectedIndex;
            int selIndClient = lbClients.SelectedIndex;

            cmbGroups.Items.Clear();
            

            foreach (var g in groups)
                cmbGroups.Items.Add(g);

            if (groups.Count > 0)
            {
                if (selIndGroup >= 0)
                    cmbGroups.SelectedIndex = selIndGroup;
                else cmbGroups.SelectedIndex = 0;
            }

            lbClients.Items.Clear();

            foreach (var c in ((Group)cmbGroups.SelectedItem).ClientsList)
                lbClients.Items.Add(c);
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbClients.Items.Clear();
            
            pSubInfo.Visible = false;
            pSubAdd.Visible = false;

            foreach (var c in ((Group)cmbGroups.SelectedItem).ClientsList)
                lbClients.Items.Add(c);
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClients.SelectedIndex < 0) return;

            Client selectedClient = (Client)lbClients.SelectedItem;

            if (selectedClient.Subscription != null)
            {
                pSubAdd.Visible = false;
                pSubInfo.Visible = true;

                txbSubCount.Text = selectedClient.Subscription.CountTraining.ToString();
                txbSubPrice.Text = selectedClient.Subscription.SubPrice.ToString();
                dtpSubDate.Value = selectedClient.Subscription.SubDate;
            }
            else
            {
                pSubAdd.Visible = true;
                pSubInfo.Visible = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (AddNewSubscription != null)
                AddNewSubscription(this, EventArgs.Empty);

            txbNewCount.Text = string.Empty;
            txbNewPrice.Text = string.Empty;
            dtpNewDate.Value = DateTime.Today;
        }
    }
}
