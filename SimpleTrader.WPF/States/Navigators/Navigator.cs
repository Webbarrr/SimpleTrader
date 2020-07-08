using SimpleTrader.WPF.Commands;
using SimpleTrader.WPF.Models;
using SimpleTrader.WPF.ViewModels;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace SimpleTrader.WPF.States.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            { 
                _currentViewModel = value;
                this.OnPropertyChanged(nameof(this.CurrentViewModel));
            }
        }


        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
