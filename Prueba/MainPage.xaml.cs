using System.Collections;
using DevExpress.Data.Browsing;

namespace Prueba
{
    public partial class MainPage : ContentPage
    {
        IList Items {get; set;}

        public MainPage()
        {
            Items = new List<string>() { "Elemento 1", "Elemento 2", "Elemento 3" };
            InitializeComponent();
            ComboBox.Data = Items;
        }
    }

}
