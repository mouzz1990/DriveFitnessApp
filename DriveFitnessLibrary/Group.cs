namespace DriveFitnessLibrary
{
    public class Group
    {
        public int ID { get; private set; }
        public string GroupName { get; private set; }

        public Group(int id, string grname)
        {
            ID = id;
            GroupName = grname;
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
