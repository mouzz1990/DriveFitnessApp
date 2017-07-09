using System.Collections.Generic;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IGroupManager
    {
        void AddNewGroup(string groupName);
        void RemoveGroup(Group group);
        void ChangeGroupInfo(Group group, string newGroupName);
        List<Group> GetGroups();
        List<Client> GetClients(int groupId);
    }
}
