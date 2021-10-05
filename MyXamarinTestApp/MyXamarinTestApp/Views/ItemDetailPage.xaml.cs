using MyXamarinTestApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyXamarinTestApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}