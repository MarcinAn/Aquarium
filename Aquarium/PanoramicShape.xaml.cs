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
    /// Interaction logic for PanoramicShape.xaml
    /// </summary>
    public partial class PanoramicShape : Page
    {
        public PanoramicShape()
        {
            InitializeComponent();
        }

        private void PanoramicCalculate_Click(object sender, RoutedEventArgs e)
        {
            VolumeCalculate volumeCalculate = new VolumeCalculate();
            PanoramicVolume.Content = volumeCalculate.PanoramicVolume(PanoramicHeight.Text, PanoramicWidth.Text, PanoramicDepthLong.Text, PanoramicDepthShort.Text);
        }
    }
}
