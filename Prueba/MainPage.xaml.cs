using System.Collections;
using Prueba.Entities;
using Prueba.Utils;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        IList<Instrument> Items {get; set;}
        string SelectedItem { get; set; } = "Ninguno está seleccionado";

        public MainPage()
        {
            Items = Utils.Utils.GetDemoData();
            InitializeComponent();
            ComboBox.Data = (IList) Items;
            MainLabel.Text = SelectedItem;
        }

        void OnChangeItem(dynamic Item, EventArgs e)
        {
            MainLabel.Text = Item;
        }
    }

}
