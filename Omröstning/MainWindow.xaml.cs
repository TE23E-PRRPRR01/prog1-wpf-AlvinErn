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

namespace EnkelOmröstning;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //Variabler för färger
    

    

    //Variabler för att räkna röster
    private int antalFärg1 = 0;
    private int antalFärg2 = 0;
    private int antalFärg3 = 0;
    private int antalFärg4 = 0;
    private int antalFärg5 = 0;
    private int antalFärg6 = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    // Metod som används när en röstknapp klickas
    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        // Kollar vilken röst-knapp som tryckts och ökar motsvarande röstantal
        if (sender == plusFärg1)
        {
            antalFärg1++;
        }
        if (sender == plusFärg2)
        {
            antalFärg2++;
        }
        if (sender == plusFärg3)
        {
            antalFärg3++;
        }
        if (sender == plusFärg4)
        {
            antalFärg4++;
        }
        if (sender == plusFärg5)
        {
            antalFärg5++;
        }
        if (sender == plusFärg6)
        {
            antalFärg6++;
        }

        //Uppdaterar resultatet i textfältet
        txbResultat.Text = $"{färg1.Text}: {antalFärg1}, {färg2.Text}: {antalFärg2}, {färg3.Text}: {antalFärg3}, {färg4.Text}: {antalFärg4}, {färg5.Text}: {antalFärg5}, {färg6.Text}: {antalFärg6}";
    }

    // Metod som används när en minus röstknapp klickas
    private void KlickMinusRöst(object sender, RoutedEventArgs e)
    {
    // Kollar vilken minus röst-knapp som tryckts och minskar motsvarande röstantal
    if (sender == minusFärg1 && antalFärg1 >= 1)
    {
        antalFärg1--;
    }
    if (sender == minusFärg2 && antalFärg2 >= 1)
    {
        antalFärg2--;
    }
    if (sender == minusFärg3 && antalFärg3 >= 1)
    {
        antalFärg3--;
    }
    if (sender == minusFärg4 && antalFärg4 >= 1)
    {
        antalFärg4--;
    }
    if (sender == minusFärg5 && antalFärg5 >= 1)
    {
        antalFärg5--;
    }
    if (sender == minusFärg6 && antalFärg6 >= 1)
    {
        antalFärg6--;
    }
        
        //Uppdaterar resultatet i textfältet
        txbResultat.Text = 
        $"{färg1.Text}: {antalFärg1}, {färg2.Text}: {antalFärg2}, {färg3.Text}: {antalFärg3}, {färg4.Text}: {antalFärg4}, {färg5.Text}: {antalFärg5}, {färg6.Text}: {antalFärg6}";
    }

    // Metod som används när "nollställ" knappen klickas
    private void KlickNollställ(object sender, RoutedEventArgs e)
    {
        //Nollställ alla röster
        antalFärg1 = 0;
        antalFärg2 = 0;
        antalFärg3 = 0;
        antalFärg4 = 0;
        antalFärg5 = 0;
        antalFärg6 = 0;
        
        //Uppdaterar resultatet i textfältet
        txbResultat.Text = 
        $"{färg1.Text}: {antalFärg1}, {färg2.Text}: {antalFärg2}, {färg3.Text}: {antalFärg3}, {färg4.Text}: {antalFärg4}, {färg5.Text}: {antalFärg5}, {färg6.Text}: {antalFärg6}";
    }

    // Metod som används när "ändra färger" knappen klickas
    private void KlickÄndraFärger(object sender, RoutedEventArgs e)
    {
        // Skriver ut färgerna på knappar
        txbPlusFärg1.Text = $"{färg1.Text}";
        txbMinusFärg1.Text = $"{färg1.Text}";

        txbPlusFärg2.Text = $"{färg2.Text}";
        txbMinusFärg2.Text = $"{färg2.Text}";

        txbPlusFärg3.Text = $"{färg3.Text}";
        txbMinusFärg3.Text = $"{färg3.Text}";

        txbPlusFärg4.Text = $"{färg4.Text}";
        txbMinusFärg4.Text = $"{färg4.Text}";

        txbPlusFärg5.Text = $"{färg5.Text}";
        txbMinusFärg5.Text = $"{färg5.Text}";

        txbPlusFärg6.Text = $"{färg6.Text}";
        txbMinusFärg6.Text = $"{färg6.Text}";

        // Ändrar namn på färgerna i resultat fältet
        txbResultat.Text = $"{färg1.Text}: 0, {färg2.Text}: 0, {färg3.Text}: 0, {färg4.Text}: 0, {färg5.Text}: 0, {färg6.Text}: 0";
        
    }
}