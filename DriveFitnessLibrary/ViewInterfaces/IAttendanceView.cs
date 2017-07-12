using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IAttendanceView
    {
        //Client Client { get; }
        DateTime DateVisit { get; }
        float Price { get; }

        Client GetClient();
        void DisplayGroups(List<Group> group);

        event EventHandler VisitationChecked;
        event EventHandler FormLoaded;
    }
}
