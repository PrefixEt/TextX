using System.Windows.Forms;

namespace TextX
{


    public interface IShowMessage
    {
        void ShowMessage(string message);
        void ShowExclamatiom(string exclamation);
        void ShowError(string error);
    }



    class MessageService:IShowMessage
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamatiom(string exclamatiom)
        {
            MessageBox.Show(exclamatiom, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
