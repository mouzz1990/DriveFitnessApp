using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IMessager
    {
        void SuccessMessage(string message);
        void ExclamationMessage(string message);
        void ErrorMessage(string message);
    }
}
