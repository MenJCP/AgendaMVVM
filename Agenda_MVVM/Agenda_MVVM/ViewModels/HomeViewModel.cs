using Agenda_MVVM.Models;
using Agenda_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Agenda_MVVM.ViewModels
{
    public class HomeViewModel
    {
        // ObservableCollection permite denotar cambios a diferencia de la lista
        public ObservableCollection<Agenda> Agendas { get; }
        public string Name { get; set; }
        public string Number { get; set; }
        public ICommand DeleteCommand { get; }
        public ICommand MoreCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand CallCommand { get; }
        public HomeViewModel()
        {
            DeleteCommand = new Command<Agenda>(OnDeleteAgenda);
            MoreCommand = new Command<Agenda>(OnMoreAgenda);
            AddCommand = new Command(OnAddAgenda);
            CallCommand = new Command(OnCallAgenda);

            Agendas = new ObservableCollection<Agenda>
            {
                new Agenda("Juan","809-123-1234")
                
            };

        }

        private void OnCallAgenda()
        {
            throw new NotImplementedException();
        }

        private async void OnAddAgenda()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        private async void OnMoreAgenda(Agenda agenda)
        {

            var Alert = await App.Current.MainPage.DisplayActionSheet("", "Cancel", "", "Call", "Edit");
            
            if(Alert == "Call")
            {
                PhoneDialer.Open(agenda.Number);
            }
                    
        }

        private void OnDeleteAgenda(Agenda agenda)
        {
           Agendas.Remove(agenda);
        }
    }
}