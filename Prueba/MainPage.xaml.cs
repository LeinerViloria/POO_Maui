using System.Collections;
using Prueba.Entities;
using Prueba.Utils;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        IList<Instrument> Items {get; set;}

        public MainPage()
        {
            Items = Utils.Utils.GetDemoData();
            InitializeComponent();
            ComboBox.Data = (IList) Items;
            ComboBox.Picker.ItemDisplayBinding = new Binding("Name");
        }

        void OnChangeItem(dynamic Item, EventArgs e)
        {
            
        }
    }

}
