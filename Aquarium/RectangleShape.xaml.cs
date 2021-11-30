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
    /// Interaction logic for RectangleShape.xaml
    /// </summary>
    public partial class RectangleShape : Page
    {
        public RectangleShape()
        {
            InitializeComponent();
        }

        private void RectangleCalculate_Click(object sender, RoutedEventArgs e)
        {
            VolumeCalculate volumeCalculate = new VolumeCalculate();
            RectangleVolume.Content = volumeCalculate.RactagleVolume(RectangleHeight.Text, RectangleWidth.Text, RectangleDepth.Text);
        }
    }
}
