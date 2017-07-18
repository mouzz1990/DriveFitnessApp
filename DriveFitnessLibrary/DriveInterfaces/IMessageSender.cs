using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IMessageSender
    {
        void SendMessage(Client Client, string Subject, string Message, string login, string password);
    }
}
