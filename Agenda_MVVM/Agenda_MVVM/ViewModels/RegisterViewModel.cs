using Agenda_MVVM.Models;
using Agenda_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda_MVVM.ViewModels
{
   public class RegisterViewModel: HomeViewModel
    {
        public string NameText { get; } = "Name";
        public string NumberText { get; } = "Number";
        public string AddText { get; } = "Add";
        public ICommand AddButton { get; }

        

        public RegisterViewModel()
        {
            AddButton = new Command<Agenda>(OnAddButton);

            
        }

        private async void OnAddButton(Agenda contact)
        {
            await App.Current.MainPage.DisplayAlert("Registro Exitoso", "El contacto ha sido agregado  ", "OK");
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            contact = new Agenda(Name, Number);

            Agendas.Add(contact);
        }
    }
}
