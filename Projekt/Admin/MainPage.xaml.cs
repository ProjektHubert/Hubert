using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OpretSmykke
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

        private void tilOpretKnap_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpretSide), null);
        }

        private void tilFjernKnap_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FjernSide));
        }

        private void tilButikKnap_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}