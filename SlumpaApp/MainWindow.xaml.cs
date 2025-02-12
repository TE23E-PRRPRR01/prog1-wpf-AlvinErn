using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        // Gör maxtal från string till int

        if (int.TryParse(maxTal.Text, out int maxTalet))
        {
        maxTalet = int.Parse(maxTal.Text);
        }
        else
        {
            felMeddelande.Text = "Du har anget ett ogiltigt maxtal. Vänligen ange ett heltal!       Maxtalet sattes till 100.";
            maxTalet = 100;
            maxTal.Text = "100";
        }
        // Generare ett slumpat mellan 1 och 100
        int slumptal = Random.Shared.Next(1, maxTalet+1);

        // Visa slumptalet i textboxen resultat
        Resultat.Text = slumptal.ToString();
    }
    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        //Rensa resultat
        Resultat.Text = "";

        //Rensa mextal
        maxTal.Text = "";

        //Rensa fel-meddelande
        felMeddelande.Text = "";
    }
}