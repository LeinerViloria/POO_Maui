using System.Collections;
using DevExpress.Data.Browsing;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        IList Items {get; set;}
        string SelectedItem { get; set; } = "Ninguno está seleccionado";

        public MainPage()
        {
            Items = new List<string>() { "Elemento 1", "Elemento 2", "Elemento 3" };
            InitializeComponent();
            ComboBox.Data = Items;
            MainLabel.Text = SelectedItem;
        }

        void OnChangeItem(dynamic Item, EventArgs e)
        {
            MainLabel.Text = Item;
        }
    }

}
