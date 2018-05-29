using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Admin.Model.Catalog;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Admin.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            await ProduktCatalog.Instance.LoadAsync();
            await ButikCatalog.Instance.LoadAsync();
            await ProduktListeCatalog.Instance.LoadAsync();
        }
    }
}
