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
    /// Interaction logic for BottomSurface.xaml
    /// </summary>
    public partial class BottomSurfaceVolume : Page
    {
        SurfaceCalculate surface = new SurfaceCalculate();
        public BottomSurfaceVolume()
        {
            InitializeComponent();
            SurfaceUnitValue.Items.Add(surface.units[0] + "\u00b2");
            SurfaceUnitValue.Items.Add(surface.units[1] + "\u00b2");
            SurfaceUnitValue.Items.Add(surface.units[2] + "\u00b2");
            ExpectationBottomUnitValue.Items.Add(surface.units[0]);
            ExpectationBottomUnitValue.Items.Add(surface.units[1]);
            ExpectationBottomUnitValue.Items.Add(surface.units[2]);
            ResultUnitValue.Items.Add(surface.units[0] + "\u00b3");
            ResultUnitValue.Items.Add(surface.units[1] + "\u00b3");
            ResultUnitValue.Items.Add(surface.units[2] + "\u00b3");
            ResultUnitValue.Items.Add(surface.units[3]);
            ResultUnitValue.Items.Add(surface.units[4]);
        }

        private void ResulSurfacetButton_Click(object sender, RoutedEventArgs e)
        {
            Result.Content=surface.Surface(SurfaceValue.Text, SurfaceUnitValue.Text, ExpectationBottomValue.Text, ExpectationBottomUnitValue.Text, ResultUnitValue.Text);
        }
    }
}
