using LocalizeApplication.ViewModel;
using LocalizeApplication.Model;
using DevExpress.Maui.Controls;

namespace LocalizeApplication.Views;

public partial class Collection : ContentPage {

    public Collection() {
        InitializeComponent();
        BindingContext = new CollectionViewModel();
    }

    void emailClicked(System.Object sender, System.EventArgs e)
    {
        var clickeditem = (sender as SimpleButton).BindingContext as CallData;
        DisplayAlert(clickeditem.ContactName, clickeditem.ContactPhone + "\n" + clickeditem.CallDate, "OK");
    }
}