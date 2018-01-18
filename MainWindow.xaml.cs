using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO


namespace Offerte_en_Facturatie_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        // Menu knop "Klant" met dropdown opties.
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            maintab.SelectedItem = tabKlantMenu;
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        //Dropdown optie Nieuwe Klant
        private void BtnNieuweKlant_Click(object sender, RoutedEventArgs e)
        {
            klanttabControl.SelectedItem = tab_NieuweKlant;
        }

        // Dropdown optie Klant Bekijken
        private void BtnKlantBekijken_Click(object sender, RoutedEventArgs e)
        {
            klanttabControl.SelectedItem = tab_KlantBekijken;
        }

        // Dropdown optie Klant Aanpassen
        private void BtnKlantAanpassen_Click(object sender, RoutedEventArgs e)
        {
            klanttabControl.SelectedItem = tab_KlantAanpassen;
        }

        // Menu knop "Offerte" met dropdown opties.
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            maintab.SelectedItem = tabOfferteMenu;
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        // Dropdown optie Nieuwe Offerte
        private void BtnNieuweOfferte_Click(object sender, RoutedEventArgs e)
        {
            offertetabControl.SelectedItem = tab_NieuweOfferte;
        }

        // Dropdown optie Offerte Bekijken
        private void BtnOfferteBekijken_Click(object sender, RoutedEventArgs e)
        {
            offertetabControl.SelectedItem = tab_OfferteBekijken;
        }

        // Menu knop "Factuur" met dropdown opties.
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            maintab.SelectedItem = tabFactuurMenu;
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        // Dropdown optie Nieuwe Factuur
        private void BtnNieuweFactuur_Click(object sender, RoutedEventArgs e)
        {
            factuurtabControl.SelectedItem = tab_NieuweFactuur;
        }

        // Dropdown optie Factuur Bekijken
        private void BtnFactuurBekijken_Click(object sender, RoutedEventArgs e)
        {
            factuurtabControl.SelectedItem = tab_FactuurBekijken;
        }

        // Applcatie afsluiten
        private void MenuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Eigen bedrijfs gegevens inzien en aanpassen
        private void MenuMijnBedrijf_Click(object sender, RoutedEventArgs e)
        {
            //Voeg hier de DB locatie in voor eigen bedrijf
        }

        // Informatie over de applicatie
        private void MenuInfo_Click(object sender, RoutedEventArgs e)
        {
            // messagebox met info over de app (ontwikkeld door, versie etc..)
        }

        // Documentatie voor de applicatie
        private void MenuDocumentatie_Click(object sender, RoutedEventArgs e)
        {
            // link naar de pdf met de documentatie
            //Process.Start(@"c:\Documentatie\Documentatie.pdf");

            //String openPDFFile = @"c:\Documentatie\Documentatie.pdf";
            //System.IO.File.WriteAllBytes(openPDFFile, Properties.Resources.Documentatie;
            //Process.Start(openPDFFile);
        }
    }
}
