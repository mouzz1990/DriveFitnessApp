using DriveFitnessLibrary.Managers;
using System;
using System.Windows.Forms;
using DriveFitnessLibrary.Presenters;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.MessageSenders;

namespace DriveFitnessApp
{
    public partial class DriveFitness : Form
    {
        static Messager messager = new Messager();
        static MySqlManager dataBaseManager = new MySqlManager();
        static ClientCardCreatorManager cardCreatorManager = new ClientCardCreatorManager();
        static ReportManager reportManager = new ReportManager(dataBaseManager);
        static GroupManager groupManager = new GroupManager(dataBaseManager, messager);
        static SubscriptionManager subscriptionManager = new SubscriptionManager(dataBaseManager, messager);
        static ClientManager clientManager = new ClientManager(dataBaseManager, messager, subscriptionManager);
        static AttendanceManager attendanceManager = new AttendanceManager(subscriptionManager);
        static MessageSenderEmail messageSender = new MessageSenderEmail(messager);
        
        public DriveFitness()
        {
            InitializeComponent();
        }

        private void BtnAddNewClient_Click(object sender, EventArgs e)
        {
            AddNewClient newClientForm = new AddNewClient();
            ClientPresenter clPres = new ClientPresenter(newClientForm, clientManager, groupManager, cardCreatorManager, messager);

            newClientForm.ShowDialog();
        }

        private void BtnChangeClientInfo_Click(object sender, EventArgs e)
        {
            ChangeClientInfo chClient = new ChangeClientInfo();
            ClientPresenter clPress = new ClientPresenter(chClient, clientManager, groupManager, cardCreatorManager, messager);

            chClient.ShowDialog();
        }

        private void BtnGroupManage_Click(object sender, EventArgs e)
        {
            GroupView grF = new GroupView();
            GroupPresenter gp = new GroupPresenter(grF, dataBaseManager, messager, groupManager);

            grF.ShowDialog();

        }

        private void BtnSubscription_Click(object sender, EventArgs e)
        {
            SubscriptionForm sf = new SubscriptionForm();

            SubscriptionPresenter sp = new SubscriptionPresenter(subscriptionManager, groupManager, messager, clientManager, sf);

            sf.ShowDialog();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            ReportPresenter rp = new ReportPresenter(reportManager, groupManager, rf);

            rf.ShowDialog();
        }

        private void BtnAttendance_Click(object sender, EventArgs e)
        {
            
            AttendanceSelectForm atSelect = new AttendanceSelectForm(attendanceManager, groupManager);

            atSelect.ShowDialog();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAttendance2_Click(object sender, EventArgs e)
        {
            
        }

        private void msSendMessage_Click(object sender, EventArgs e)
        {
            MessageSenderForm msf = new MessageSenderForm();

            SenderMessagePresenter smp = new SenderMessagePresenter(groupManager, messageSender, messager, msf);
            msf.ShowDialog();
        }
    }
}
