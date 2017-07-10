using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IGroupView
    {
        Group Group { get; }
        string NewGroupName { get; }
        string EditedGroupName { get; }

        void RefreshGroupsList(List<Group> groupList);

        event EventHandler AddNewGroup;
        event EventHandler ChangeGroup;
        event EventHandler RemoveGroup;
        event EventHandler RefreshGroupList;
    }
}
