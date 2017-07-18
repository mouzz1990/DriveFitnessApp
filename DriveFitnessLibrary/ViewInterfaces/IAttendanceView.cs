using System;
using System.Collections.Generic;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface IAttendanceView
    {
        DateTime DateVisit { get; }
        float Price { get; }

        Client GetClient();
        void DisplayGroups(List<Group> group);
        void DisplayVisitedDates(List<DateTime> datesVisitation);

        event EventHandler VisitationChecked;
        event EventHandler FormLoaded;
        event EventHandler ClientChanged;
        event EventHandler VisitationDeleted;
    }
}
