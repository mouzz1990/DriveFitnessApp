namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IClientManager
    {
        void AddNewClient(Client client, Group group);
        void RemoveClient(Client client);
        void ChangeClientInformation(Client client, Group group);
        void BuySubscription(Client client, Subscription subscription);
    }
}
