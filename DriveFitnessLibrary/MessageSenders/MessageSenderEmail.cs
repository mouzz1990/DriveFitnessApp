using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.DriveInterfaces;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;

namespace DriveFitnessLibrary.MessageSenders
{
    public class MessageSenderEmail : IMessageSender
    {
        IMessager messager;
        public MessageSenderEmail(IMessager messager)
        {
            this.messager = messager;
        }


        public void SendMessage(Client Client, string Subject, string Message, string login, string password)
        {
            Thread.Sleep(500);
            try
            {
                if (!IsValidEmail(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(password))
                {
                    throw new FormatException();
                }

                MailAddress MailFrom = new MailAddress(login);

                if (IsValidEmail(Client.Email))
                {
                    MailAddress MailTo = new MailAddress(Client.Email);

                    MailMessage mailMessage = new MailMessage(MailFrom, MailTo);

                    mailMessage.Subject = Subject;

                    mailMessage.Body = Message;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                    smtp.Credentials = new NetworkCredential(login, password);

                    smtp.EnableSsl = true;

                    smtp.Send(mailMessage);
                }
                else
                {
                    messager.ErrorMessage(string.Format("У клиента \"{0}\" введен некорректный email: \"{1}\"{2}{2}Сообщение клиенту \"{0}\" не отправлено!",
                        Client,
                        Client.Email,
                        Environment.NewLine
                        ));
                };
            }
            catch (SmtpException)
            {
                messager.ErrorMessage("Возникла ошибка при прохождении проверки логина и пароля отправителя. Пожалуйста проверьте введенные вами данные и повторите попытку.");
                throw new SmtpException();
            }
            catch (FormatException)
            {
                messager.ErrorMessage("Введен некорректный email-адресс отправки! Пожалуйста проверьте email и повторите попытку.");
                throw new FormatException();
            }

        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email)) return false;

                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    MailAddress mail = new MailAddress(email);
                    return true;
                }
                else return false;
            }
            catch (FormatException exc)
            {
                return false;
            }
        }
    }
}
