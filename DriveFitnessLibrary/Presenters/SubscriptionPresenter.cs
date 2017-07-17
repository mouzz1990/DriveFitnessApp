using System;
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
            view.CloseSubscription += View_CloseSubscription;
            view.ChangeSubscription += View_ChangeSubscription;
            view.RemoveSubscription += new EventHandler(view_RemoveSubscription);
        }

        void view_RemoveSubscription(object sender, EventArgs e)
        {
            subscriptionManager.RemoveSubscription(view.Client);
        }

        private void View_ChangeSubscription(object sender, EventArgs e)
        {
            subscriptionManager.ChangeSubscriptionData(
                view.Client, 
                view.SelectedSubscriptionCount, 
                view.SelectedSubscriptionPrice,
                view.SelectedSubscriptionDate
                );
        }

        private void View_CloseSubscription(object sender, EventArgs e)
        {
            subscriptionManager.CloseSubscription(view.Client);
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
