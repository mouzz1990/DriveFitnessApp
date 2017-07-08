using System.Data;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IDataBaseExecutable
    {
        DataTable GetData(string querryString);
        void SendCommand(string querryString);
        int GetNextId(string tableName);
    }
}
