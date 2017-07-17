using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface ISenderMessageView
    {
        string Login { get; }
        string Password { get; }
        string Subject { get; }
        string Message { get; }

        void DisplayGroups(List<Group> groupList);
        List<Client> ClientsListToSendMessage { get; }

        event EventHandler SendMessageClicked;
        event EventHandler RequestToFillGroups;
    }
}
