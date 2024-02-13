using System.Collections;
using Prueba.Entities;
using Prueba.Interfaces;
using Prueba.Utils;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        IList<Instrument> Items {get; set;}
        Instrument ItemSelected { get; set; }

        public MainPage()
        {
            Items = Utils.Utils.GetDemoData();
            InitializeComponent();
            ComboBox.Data = (IList) Items;
            ComboBox.Picker.ItemDisplayBinding = new Binding("Name");
        }

        void OnChangeItem(dynamic Item, EventArgs e)
        {
            ItemSelected = Item;
            ImageElement.Source = ItemSelected.Image;
            TitleTag.Text = ItemSelected.Name;
            TitleTag.Text = ItemSelected.Description;
        }

        void Sound(object sender, EventArgs args)
        {
            ISound Obj = ItemSelected;
            Obj.Sound();
        }
    }

}
