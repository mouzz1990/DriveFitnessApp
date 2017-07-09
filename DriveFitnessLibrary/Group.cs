using System.Collections.Generic;

namespace DriveFitnessLibrary
{
    public class Group
    {
        public int ID { get; private set; }
        public string GroupName { get; private set; }
        public List<Client> ClientsList { get; private set; }

        public Group(int id, string grname, List<Client> clist)
        {
            ID = id;
            GroupName = grname;
            ClientsList = clist;
        }

        public override string ToString()
        {
            return GroupName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            return this.ID == (obj as Group).ID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
