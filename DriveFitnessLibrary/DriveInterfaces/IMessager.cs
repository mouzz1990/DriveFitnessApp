namespace DriveFitnessLibrary.DriveInterfaces
{
    public interface IMessager
    {
        void SuccessMessage(string message);
        void ExclamationMessage(string message);
        void ErrorMessage(string message);
    }
}
