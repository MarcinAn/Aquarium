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
        public BottomSurfaceVolume()
        {
            InitializeComponent();
            Surface surface = new Surface();
            CapacityUnits.Items.Add(surface.units[0] + "\u00b2");
            CapacityUnits.Items.Add(surface.units[1] + "\u00b2");
            CapacityUnits.Items.Add(surface.units[2] + "\u00b2");
            SurfaceUnits.Items.Add(surface.units[0]);
            SurfaceUnits.Items.Add(surface.units[1]);
            SurfaceUnits.Items.Add(surface.units[2]);
            ResulSurfacetUnits.Items.Add(surface.units[0] + "\u00b2");
            ResulSurfacetUnits.Items.Add(surface.units[1] + "\u00b2");
            ResulSurfacetUnits.Items.Add(surface.units[2] + "\u00b2");
        }
    }
}
