using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.ViewInterfaces;
using DriveFitnessLibrary.DriveInterfaces;

namespace DriveFitnessLibrary.Presenters
{
    public class ClientPresenter
    {
        IClientView view;
        IClientManager clientManager;
        IGroupManager groupManager;
        IMessager messager;
        IClientCardCreator clientCardCreator;

        public ClientPresenter(IClientView view, IClientManager clientManager, IGroupManager groupManager, IMessager messager)
        {
            this.view = view;
            this.clientManager = clientManager;
            this.groupManager = groupManager;
            this.messager = messager;

            view.GroupsRequred += new EventHandler(view_GroupsRequred);
            view.AddClientClicked += new EventHandler(view_AddClientClicked);
            
            view.ClientInformationChanged += new EventHandler(view_ClientInformationChanged);
            view.ClientDeleted += new EventHandler(view_ClientDeleted);
            view.GroupChanged += new EventHandler(view_GroupChanged);
            view.CreateClientCard += new EventHandler(view_CreateClientCard);
        }

        void view_CreateClientCard(object sender, EventArgs e)
        {
            ClientEventArgs clArg = (ClientEventArgs)e;
            Client client = clArg.client;

            clientCardCreator.MakeClientCard(client);
        }

        void view_GroupChanged(object sender, EventArgs e)
        {
            view.RefreshForm();
        }

        void view_ClientDeleted(object sender, EventArgs e)
        {
            ClientEventArgs clientEvArgs = (ClientEventArgs)e;
            Client removableClient = clientEvArgs.client;
            Group selGr = view.Group;

            clientManager.RemoveClient(removableClient);
            
            view.DisplayGroups(groupManager.GetGroups());

            view.SelectGroup(selGr);

            view.RefreshForm();
        }

        void view_ClientInformationChanged(object sender, EventArgs e)
        {
            Client client = ((ClientEventArgs)e).client;
            Group selGr = view.Group;

            string lastname = view.LastNameClient;
            string name = view.NameClient;
            DateTime birthday = view.Birthday;
            string telephone = view.Telephone;
            string email = view.Email;

            Client UpdatedClient = new Client(client.ID, name, lastname, birthday, email, telephone);
            
            clientManager.ChangeClientInformation(UpdatedClient, view.ClientGroup);

            view.DisplayGroups(groupManager.GetGroups());

            view.SelectGroup(selGr);

            view.RefreshForm();
        }

        void view_AddClientClicked(object sender, EventArgs e)
        {
            string name = view.NameClient;
            string lastName = view.LastNameClient;
            DateTime birthday = view.Birthday;
            string email = view.Email;
            string telephone = view.Telephone;

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrEmpty(telephone) || string.IsNullOrWhiteSpace(telephone) 
                )
            {
                messager.ErrorMessage(string.Format("Ошибка добавления клиента!{0}{0}Необходимо заполнить обязательные поля формы помеченные символом \"*\".",
                    Environment.NewLine
                    ));

                return;
            }

            Client newClient = new Client(name, lastName, birthday, email, telephone);

            clientManager.AddNewClient(newClient, view.Group);

            view.RefreshForm();
        }

        void view_GroupsRequred(object sender, EventArgs e)
        {
            view.DisplayGroups(groupManager.GetGroups());
        }

    }
}
