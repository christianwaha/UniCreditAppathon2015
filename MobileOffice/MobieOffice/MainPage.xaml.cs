using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace MobieOffice
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public IBankConnector BankConnector { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.BankConnector = new UniCreditConnector();


        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await this.BankConnector.GetBranches();



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            //.Text = "Thanks for your appointment request!";
        }
    }
}
