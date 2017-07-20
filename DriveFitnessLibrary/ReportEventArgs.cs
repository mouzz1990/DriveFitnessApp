using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DriveFitnessLibrary
{
    class ReportEventArgs : EventArgs
    {
        DataTable data;
        string saveToPath;

        public ReportEventArgs() { }

        public ReportEventArgs(DataTable data, string saveToPath)
        {
            this.data = data;
            this.saveToPath = saveToPath;
        }
    }
}
