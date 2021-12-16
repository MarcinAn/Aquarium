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

namespace Aquarium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Menu.Content = new Menu();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new Menu();
        }

        private void AquariumVolumeButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new AquariumVolume();
        }

        private void BottomSurfaceButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new BottomSurfaceVolume();
        }

        private void PowerConsumptionButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new PowerConsumption();
        }
    }
}
