using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DriveFitnessLibrary.MessageSenders;
using DriveFitnessLibrary;
using DriveFitnessLibrary.DriveInterfaces;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Mail;
using DriveFitnessLibrary.ViewInterfaces;

namespace DriveFitnessApp
{
    public partial class MessageSenderForm : Form, ISenderMessageView
    {
        public MessageSenderForm()
        {
            InitializeComponent();
        }

        public List<Client> ClientsListToSendMessage 
        {
            get 
            { 
                List<Client> clients = new List<Client>();

                foreach (var c in clbClients.CheckedItems)
                {
                    Client client = (Client)c;
                    clients.Add(client);
                }
                return clients;
            } 
        }

        private void BtnSnd_Click(object sender, EventArgs e)
        {
            if (SendMessageClicked != null)
                SendMessageClicked(this, EventArgs.Empty);

            //foreach (var c in clbClients.CheckedItems)
            //{
            //    try
            //    {
            //        Client client = (Client)c;
            //        messageSenderEmail.SendMessage(
            //            client,
            //            txbSubject.Text,
            //            txbMessage.Text,
            //            txbLogin.Text,
            //            txbPassword.Text
            //        );
            //    }
            //    catch (FormatException)
            //    {
            //        messager.ErrorMessage("Отправка сообщений отменена!");
            //        return;
            //    }

            //    catch (SmtpException)
            //    {
            //        messager.ErrorMessage("Отправка сообщений отменена!");
            //        return;
            //    }
            //}
            //messager.SuccessMessage("Отправка сообщений завершена!");
        }

        private void MessageSenderForm_Load(object sender, EventArgs e)
        {
            if (RequestToFillGroups != null)
                RequestToFillGroups(this, EventArgs.Empty);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbClients.Items.Clear();

            foreach (var c in ((Group)cmbGroup.SelectedItem).ClientsList)
                clbClients.Items.Add(c);
        }

        bool checkedAll = false;

        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            if (!checkedAll)
            {
                for (int i = 0; i < clbClients.Items.Count; i++)
                    clbClients.SetItemChecked(i, true);
                checkedAll = true;
            }
            else
            {
                for (int i = 0; i < clbClients.Items.Count; i++)
                    clbClients.SetItemChecked(i, false);
                checkedAll = false;
            }
        }

        public void DisplayGroups(List<Group> groupList)
        {
            foreach (var g in groupList)
                cmbGroup.Items.Add(g);

            if (cmbGroup.Items.Count > 0)
                cmbGroup.SelectedIndex = 0;
        }
        
        public event EventHandler RequestToFillGroups;
        public event EventHandler SendMessageClicked;

        public string Login
        {
            get { return txbLogin.Text; }
        }

        public string Password
        {
            get { return txbPassword.Text; }
        }

        public string Subject
        {
            get { return txbSubject.Text; }
        }

        public string Message
        {
            get { return txbMessage.Text; }
        }
    }
}
