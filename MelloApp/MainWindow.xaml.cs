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

namespace MelloApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Variabler för rösterna
    int antalRöd = 0;
    int antalBlå = 0;
    int antalGrön = 0;
    int antalSvart = 0;
    int antalVit = 0;

    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        // Kolla vilken knapp som klickas och addera röst till den färgen

        if (sender == rödRöst)
        {
            antalRöd++;
        }
        if (sender == blåRöst)
        {
            antalBlå++;
        }
        if (sender == grönRöst)
        {
            antalGrön++;
        }
        if (sender == svartRöst)
        {
            antalSvart++;
        }
        if (sender == vitRöst)
        {
            antalVit++;
        }

        // Skriv ut rösterna i resultatet
        Resultat.Text = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Svart: {antalSvart}, Vit: {antalVit}";
    }

    private void KlickNollställ(object sender, RoutedEventArgs e)
    {
        // Sätt alla antal röster till 0

        antalRöd = 0;
        antalBlå = 0;
        antalGrön = 0;
        antalSvart = 0;
        antalVit = 0;
        
        // Skriv ut resultatet vilket nu är nollställt
        Resultat.Text = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Svart: {antalSvart}, Vit: {antalVit}";
    }
}