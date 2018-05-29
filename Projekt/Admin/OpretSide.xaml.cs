using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Data.SqlClient;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OpretSide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OpretSide : Page
    {
        public OpretSide()
        {
 
            this.InitializeComponent();
        }
 
        private void annullerProduktKnap_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
 
        private void opretProduktKnap_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = null;
            string sql1;
            string sql2;
            connectionString = "Server=tcp:projekt-hubert.database.windows.net,1433; Initial Catalog=HubertDB; Persist Security Info = False; User ID=Hubert; Password=Analrundfart1; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                sql2 = "INSERT INTO Produkt (ProduktID, ProduktNavn, Materiale, Type) VALUES (@ProduktID, @ProduktNavn, @Materiale, @Type)";
                sql1 = "INSERT INTO ProduktListe (fkProduktID, fkButikID, Pris, Antal, Stoerrelse) VALUES (@ProduktID, @ButikID, @Pris, @Antal, @Size)";
                cnn.Open();
                using (SqlCommand cmd2 = new SqlCommand(sql2, cnn))
                {
                    cmd2.Parameters.AddWithValue("@ProduktID", addProdukt.Text);
                    cmd2.Parameters.AddWithValue("@ProduktNavn", addNavn.Text);
                    cmd2.Parameters.AddWithValue("@Materiale", addMateriale.Text);
                    cmd2.Parameters.AddWithValue("@Type", addType.Text);
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd1 = new SqlCommand(sql1, cnn))
                {
                    cmd1.Parameters.AddWithValue("@ProduktID", addProdukt.Text);
                    cmd1.Parameters.AddWithValue("@ButikID", butikDropDown.SelectedIndex+1);
                    cmd1.Parameters.AddWithValue("@Pris", addPris.Text);
                    cmd1.Parameters.AddWithValue("@Antal", addAntal.Text);
                    cmd1.Parameters.AddWithValue("@Size", addSize.Text);
                    cmd1.ExecuteNonQuery();
                    opretPopup.IsOpen = true;
                }
 
                cnn.Close();
            }
        }
        private void lukPopup_Click(object sender, RoutedEventArgs e)
        {
            {
                opretPopup.IsOpen = false;
            }
        }
    }
}