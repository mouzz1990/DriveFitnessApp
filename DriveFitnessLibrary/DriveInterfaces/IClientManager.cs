namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IClientManager
    {
        void AddNewClient(Client client);
        void RemoveClient(Client client);
        void ChangeClientInformation(Client client);
        void BuySubscription(Client client, Subscription subscription);
    }
}
