using System;

namespace DriveFitnessLibrary
{
    public class ClientEventArgs : EventArgs
    {
        public Client client;

        public ClientEventArgs(Client client)
        {
            this.client = client;
        }
    }
}
