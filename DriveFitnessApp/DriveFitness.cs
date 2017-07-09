using DriveFitnessLibrary;
using DriveFitnessLibrary.Managers;
using System;
using System.Windows.Forms;

namespace DriveFitnessApp
{
    public partial class DriveFitness : Form
    {
        public DriveFitness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientManager clm = new ClientManager(new MySqlManager(), new Messager());

            clm.AddNewClient(new Client("vasy", "pertrov", DateTime.Today, "asd@asd.net", "123-12-12"), new Group(3, "Fitness 3", null));
            
        }
    }
}
