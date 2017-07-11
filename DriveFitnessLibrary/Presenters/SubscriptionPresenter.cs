using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;

namespace DriveFitnessLibrary.Presenters
{
    public class SubscriptionPresenter
    {
        ISubscriptionView view;
        IClientManager clientManager;
        IGroupManager groupManager;
        ISubscriptionManager subscriptionManager;
        IMessager messager;
        IDataBaseExecutable DataBaseManager;

        public SubscriptionPresenter(ISubscriptionManager subscriptionManager, IGroupManager groupManager, IMessager messager, IClientManager clientManager, ISubscriptionView view)
        {
            this.view = view;
            this.groupManager = groupManager;
            this.subscriptionManager = subscriptionManager;
            this.messager = messager;
            this.clientManager = clientManager;

            view.AddNewSubscription += new EventHandler(view_AddNewSubscription);
            view.Refresh += new EventHandler(view_Refresh);
            view.AddNewSubscription += view_Refresh;
        }

        void view_Refresh(object sender, EventArgs e)
        {
            view.RefreshForm(groupManager.GetGroups());
        }

        void view_AddNewSubscription(object sender, EventArgs e)
        {
            int count = view.NewSubscriptionCount;
            float price = view.NewSubscriptionPrice;
            DateTime date = view.NewSubscriptionDate;

            if (count != 0 && price != 0)
            {
                Subscription subscription = Subscription.CreateNewSubscription(view.NewSubscriptionCount, view.NewSubscriptionPrice, view.NewSubscriptionDate);

                Client client = view.Client;

                clientManager.BuySubscription(client, subscription);
                //subscriptionManager.AddNewSubscription(client, subscription);
            }
            else messager.ErrorMessage("Неправильно заполнена форма!");
        }

    }
}
