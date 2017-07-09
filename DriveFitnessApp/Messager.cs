using DriveFitnessLibrary.DriveInterfaces;
using System.Windows.Forms;

namespace DriveFitnessApp
{
    public class Messager : IMessager
    {
        public void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ExclamationMessage(string message)
        {
            MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void SuccessMessage(string message)
        {
            MessageBox.Show(message, "Операция успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
