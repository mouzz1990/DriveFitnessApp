using System;
using System.Collections.Generic;

namespace DriveFitnessLibrary.ViewInterfaces
{
    public interface ISubscriptionView
    {
        int NewSubscriptionCount { get; }
        float NewSubscriptionPrice { get; }
        DateTime NewSubscriptionDate { get; }

        int SelectedSubscriptionCount { get; }
        float SelectedSubscriptionPrice { get; }
        DateTime SelectedSubscriptionDate { get; }
        
        Client Client { get; }

        void RefreshForm(List<Group> groups);
        
        event EventHandler AddNewSubscription;
        event EventHandler Refresh;
        event EventHandler ChangeSubscription;
        event EventHandler CloseSubscription;
        event EventHandler RemoveSubscription;
    }
}
