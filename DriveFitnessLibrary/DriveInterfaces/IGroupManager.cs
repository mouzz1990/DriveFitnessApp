using System.Collections.Generic;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IGroupManager
    {
        void AddNewGroup(int id, string groupName);
        void RemoveGroup(Group group);
        void ChangeGroupInfo(string groupName);
        List<Group> GetGroups();
        List<Client> GetClients(Group group);
    }
}
