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

namespace Booleans.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal1;
        int getal2;
        int getal3;
        int getal4;

        bool bewering1, bewering2;

        public MainWindow()
        {
            InitializeComponent();
        }

        void Vergelijk1(bool vergelijking, Button geklikt)
        {
            string info;
            string boolOperator = geklikt.Content.ToString();

            bewering1 = vergelijking;
            info = $"{getal1} {boolOperator} {getal2}\t{vergelijking}";

            tbkVergelijkingen1.Text = info + "\n" + tbkVergelijkingen1.Text;
        }

        void Vergelijk2(bool vergelijking, Button geklikt)
        {
            string info;
            string boolOperator = geklikt.Content.ToString();

            bewering2 = vergelijking;

            info = $"{getal3} {boolOperator} {getal4}\t{vergelijking}";

            tbkVergelijkingen2.Text = info + "\n" + tbkVergelijkingen2.Text;
        }

        void Combineer(bool logic, string bewering)
        {
            string info;
            info = bewering + logic;
            lblLogisch.Content = info;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                lstGetal1.Items.Add(i);
                lstGetal2.Items.Add(i);
                lstGetal3.Items.Add(i);
                lstGetal4.Items.Add(i);
            }

            lstGetal1.SelectedItem = 1;
            lstGetal2.SelectedItem = 5;
            lstGetal3.SelectedItem = 9;
            lstGetal4.SelectedItem = 3;
        }

        #region ListBoxHandlers
        private void lstGetal1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            getal1 = (int)lstGetal1.SelectedItem;
        }

        private void lstGetal2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            getal2 = (int)lstGetal2.SelectedItem;
        }

        private void lstGetal3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            getal3 = (int)lstGetal3.SelectedItem;
        }

        private void lstGetal4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            getal4 = (int)lstGetal4.SelectedItem;
        }
        #endregion

        private void btnGelijkAan1_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk1(getal1 == getal2, (Button)sender);
        }

        private void btnNietGelijkAan1_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk1(getal1 != getal2, (Button)sender);
        }

        private void btnKleinerDan1_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk1(getal1 < getal2, (Button)sender);
        }

        private void btnGroterDan1_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk1(getal1 > getal2, (Button)sender);
        }

        private void btnKleinerDanOfGelijkAan1_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk1(getal1 <= getal2, (Button)sender);
        }

        private void btnGroterDanOfGelijkAan1_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk1(getal1 >= getal2, (Button)sender);
        }

        private void btnGelijkAan2_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk2(getal3 == getal4, (Button)sender);
        }

        private void btnNietGelijkAan2_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk2(getal3 != getal4, (Button)sender);
        }

        private void btnKleinerDan2_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk2(getal3 < getal4, (Button)sender);
        }

        private void btnGroterDan2_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk2(getal3 > getal4, (Button)sender);
        }

        private void btnKleinerDanOfGelijkAan2_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk2(getal3 <= getal4, (Button)sender);
        }

        private void btnGroterDanOfGelijkAan2_Click(object sender, RoutedEventArgs e)
        {
            Vergelijk2(getal3 >= getal4, (Button)sender);
        }

        private void btnAnd_Click(object sender, RoutedEventArgs e)
        {
            Combineer(bewering1 && bewering2, "Beide waar: ");
        }

        private void btnOr_Click(object sender, RoutedEventArgs e)
        {
            Combineer(bewering1 || bewering2, "Eén van beide waar: ");
        }
    }
}
