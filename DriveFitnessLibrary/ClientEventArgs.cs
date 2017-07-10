using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
