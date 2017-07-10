using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IClientView
    {
        string LastNameClient { get; }
        string NameClient { get; }
        DateTime Birthday { get; }
        string Email { get; }
        string Telephone { get; }
        Group Group { get; }
        Group ClientGroup { get; }

        void SelectGroup(Group group);
        void DisplayGroups(List<Group> groupList);
        void RefreshForm();

        event EventHandler AddClientClicked;
        event EventHandler GroupsRequred;
        event EventHandler ClientInformationChanged;
        event EventHandler ClientDeleted;
        event EventHandler GroupChanged;
    }
}
