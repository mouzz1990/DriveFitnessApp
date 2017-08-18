using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFitnessLibrary.Presenters
{
    public class SchedulePresenter
    {
        IMessager messager;
        IScheduleManager ScheduleManager;
        IScheduleView view;

        public SchedulePresenter(IScheduleManager ScheduleManager, IScheduleView view, IMessager messager)
        {
            this.ScheduleManager = ScheduleManager;
            this.view = view;
            this.messager = messager;

            view.FormLoaded += View_FormLoaded;
            view.AddNewScheduleClicked += View_AddNewScheduleClicked;
            view.ChangeScheduleClicked += View_ChangeScheduleClicked;
            view.RemoveScheduleClicked += View_RemoveScheduleClicked;
            view.ScheduleRequired += View_ScheduleRequired;
        }

        private void View_ScheduleRequired(object sender, EventArgs e)
        {
            view.DisplaySchedules(ScheduleManager.GetSchedules(view.Group));
        }

        private void View_RemoveScheduleClicked(object sender, EventArgs e)
        {
            ScheduleManager.RemoveSchedule(view.Schedule);
            View_ScheduleRequired(this, EventArgs.Empty);
        }

        private void View_ChangeScheduleClicked(object sender, EventArgs e)
        {
            ScheduleManager.ChangeScheduleInformation(view.Schedule, view.ScheduleDay, view.ScheduleTime);
            View_ScheduleRequired(this, EventArgs.Empty);
        }

        private void View_AddNewScheduleClicked(object sender, EventArgs e)
        {
            ScheduleManager.AddNewSchedule(view.Group, view.ScheduleDay, view.ScheduleTime);
            View_ScheduleRequired(this, EventArgs.Empty);
        }

        private void View_FormLoaded(object sender, EventArgs e)
        {
            view.DisplayGroups(ScheduleManager.GetGroups());
        }
    }
}
