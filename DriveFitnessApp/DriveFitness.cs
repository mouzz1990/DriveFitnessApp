using DriveFitnessLibrary;
using DriveFitnessLibrary.Managers;
using System;
using System.Windows.Forms;
using DriveFitnessLibrary.Presenters;

namespace DriveFitnessApp
{
    public partial class DriveFitness : Form
    {
        static Messager messager = new Messager();
        static MySqlManager dataBaseManager = new MySqlManager();
        static GroupManager groupManager = new GroupManager(dataBaseManager, messager);
        static SubscriptionManager subscriptionManager = new SubscriptionManager(dataBaseManager, messager);
        static ClientManager clientManager = new ClientManager(dataBaseManager, messager, subscriptionManager);
        static AttendanceManager attendanceManager = new AttendanceManager(subscriptionManager);

        public DriveFitness()
        {
            InitializeComponent();
        }

        private void BtnAddNewClient_Click(object sender, EventArgs e)
        {
            AddNewClient newClientForm = new AddNewClient();
            ClientPresenter clPres = new ClientPresenter(newClientForm, clientManager, groupManager, messager);

            newClientForm.ShowDialog();
        }

        private void BtnChangeClientInfo_Click(object sender, EventArgs e)
        {
            ChangeClientInfo chClient = new ChangeClientInfo();
            ClientPresenter clPress = new ClientPresenter(chClient, clientManager, groupManager, messager);

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
    }
}
