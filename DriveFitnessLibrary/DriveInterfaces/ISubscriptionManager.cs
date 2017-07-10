namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface ISubscriptionManager
    {
        void AddNewSubscription(Client client, Subscription subscription);
        void DecreaseSubscriptionCount(Client client);
        void CloseSubscription(Client client);

        IMessager messager { get; set; }
        IDataBaseExecutable DataBaseManager { get; set; }
    }
}
