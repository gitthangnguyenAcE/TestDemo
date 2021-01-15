using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using MyApp_ss3.Views;
using MyApp_ss3.Models;
namespace MyApp_ss3.ViewModels
{
    public class AddListErrViewModel : BaseViewModel
    {
        private ListErr _selectedListErr { get; set; }
        public ListErr SelectedListErr 
        {
            get { return _selectedListErr; }
            set { if (_selectedListErr != value) _selectedListErr = value; }
        }
        public AddListErrViewModel()
        {

        }

        public ICommand OpenWebCommand { get; }
    }
}
