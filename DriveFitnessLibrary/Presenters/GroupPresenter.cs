using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;

namespace DriveFitnessLibrary.Presenters
{
    public class GroupPresenter
    {
        IMessager messager;
        IGroupManager groupManager;
        IGroupView view;

        public GroupPresenter(IGroupView view, IDataBaseExecutable DataBaseManager, IMessager messager, IGroupManager groupManager)
        {
            this.messager = messager;
            this.groupManager = groupManager;
            this.view = view;

            view.AddNewGroup += new EventHandler(view_AddNewGroup);
            view.ChangeGroup += new EventHandler(view_ChangeGroup);
            view.RemoveGroup += new EventHandler(view_RemoveGroup);
            view.RefreshGroupList += new EventHandler(view_RefreshGroupList);
        }

        void view_RefreshGroupList(object sender, EventArgs e)
        {
            view.RefreshGroupsList(groupManager.GetGroups());
        }

        void view_RemoveGroup(object sender, EventArgs e)
        {
            try
            {
                groupManager.RemoveGroup(view.Group);
                view.RefreshGroupsList(groupManager.GetGroups());
            }
            catch (RemoveGroupException rge)
            {
                throw rge;
            }
        }

        void view_ChangeGroup(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.EditedGroupName) || string.IsNullOrWhiteSpace(view.EditedGroupName))
            {
                messager.ErrorMessage("Название группы не может быть пустым. Пожалуйста укажите название создаваемой группы.");
                return;
            }
            
            groupManager.ChangeGroupInfo(view.Group, view.EditedGroupName);
            view.RefreshGroupsList(groupManager.GetGroups());
        }

        void view_AddNewGroup(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(view.NewGroupName) || string.IsNullOrWhiteSpace(view.NewGroupName))
            {
                messager.ErrorMessage("Название группы не может быть пустым. Пожалуйста введите новое название группы.");
                return;
            }
            
            groupManager.AddNewGroup(view.NewGroupName);
            view.RefreshGroupsList(groupManager.GetGroups());
        }
    }
}
