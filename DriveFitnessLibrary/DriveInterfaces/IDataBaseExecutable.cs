using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IDataBaseExecutable
    {
        DataTable GetData(string querryString);
        void SendCommand(string querryString);
        string GetNextId(string tableName);
    }
}
