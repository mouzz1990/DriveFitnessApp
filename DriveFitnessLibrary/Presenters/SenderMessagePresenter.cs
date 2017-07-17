using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.DriveInterfaces;
using DriveFitnessLibrary.ViewInterfaces;
using System.Net.Mail;

namespace DriveFitnessLibrary.Presenters
{
    public class SenderMessagePresenter
    {
        IGroupManager groupManager;
        IMessageSender messageSenderEmail;
        ISenderMessageView view;
        IMessager messager;

        public SenderMessagePresenter(IGroupManager groupManager, IMessageSender messageSender, IMessager messager, ISenderMessageView view)
        {
            this.groupManager = groupManager;
            this.messageSenderEmail = messageSender;
            this.view = view;
            this.messager = messager;

            view.RequestToFillGroups += new EventHandler(view_RequestToFillGroups);
            view.SendMessageClicked += new EventHandler(view_SendMessageClicked);
        }

        void view_SendMessageClicked(object sender, EventArgs e)
        {

            foreach (var c in view.ClientsListToSendMessage)
            {
                try
                {
                    Client client = (Client)c;
                    messageSenderEmail.SendMessage(
                        client,
                        view.Subject,
                        view.Message,
                        view.Login,
                        view.Password
                    );
                }
                catch (FormatException)
                {
                    messager.ErrorMessage("Отправка сообщений отменена!");
                    return;
                }

                catch (SmtpException)
                {
                    messager.ErrorMessage("Отправка сообщений отменена!");
                    return;
                }
            }
            messager.SuccessMessage("Отправка сообщений завершена!");
        }

        void view_RequestToFillGroups(object sender, EventArgs e)
        {
            view.DisplayGroups(groupManager.GetGroups());
        }


    }
}
