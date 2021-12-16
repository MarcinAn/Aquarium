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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aquarium
{
    /// <summary>
    /// Interaction logic for AquariumVolume.xaml
    /// </summary>
    public partial class AquariumVolume : Page
    {
        public AquariumVolume()
        {
            InitializeComponent();
        }

        private void RectangeButton_Click(object sender, RoutedEventArgs e)
        {
            AquariumVolumeShape.Content = new RectangleShape();
        }

        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            AquariumVolumeShape.Content = new TriangleShape();
        }

        private void TrapezeButton_Click(object sender, RoutedEventArgs e)
        {
            AquariumVolumeShape.Content = new TrapezeShape();
        }

        private void PanoramicButton_Click(object sender, RoutedEventArgs e)
        {
            AquariumVolumeShape.Content = new PanoramicShape();
        }
    }
}
