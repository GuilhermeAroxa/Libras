using System;
using System.Windows.Input;
using Libras.Views;
using Xamarin.Forms;

namespace Libras.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            StartCommand = new Command(() =>
            {
                Application.Current.MainPage = new TrainingView();
            });
        }
        public ICommand StartCommand { get; set; }
    }
}
