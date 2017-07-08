namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface ISubscriptionManager
    {
        void AddNewSubscription(Client client);
        void DecreaseSubscriptionCount(Client client);
        void CloseSubscription(Client client);
    }
}
