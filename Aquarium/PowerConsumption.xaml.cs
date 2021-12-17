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
    /// Interaction logic for PowerConsumption.xaml
    /// </summary>
    public partial class PowerConsumption : Page
    {
        PowerConsumptionCalc powerConsumptionCalc = new PowerConsumptionCalc();
        public PowerConsumption()
        {
            InitializeComponent();

            TypeValue.Items.Add(powerConsumptionCalc.types[0]);
            TypeValue.Items.Add(powerConsumptionCalc.types[1]);

            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[2]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[3]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[4]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[5]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[6]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[7]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[8]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[9]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[10]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[11]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[12]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[13]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[14]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[15]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[16]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[17]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[18]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[19]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[20]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[21]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[22]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[23]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[24]);
            HeaterTimeValue.Items.Add(powerConsumptionCalc.types[25]);

            FilterTimeValue.Items.Add(powerConsumptionCalc.types[2]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[3]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[4]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[5]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[6]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[7]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[8]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[9]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[10]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[11]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[12]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[13]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[14]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[15]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[16]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[17]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[18]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[19]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[20]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[21]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[22]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[23]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[24]);
            FilterTimeValue.Items.Add(powerConsumptionCalc.types[25]);

            LightTimeValue.Items.Add(powerConsumptionCalc.types[2]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[3]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[4]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[5]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[6]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[7]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[8]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[9]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[10]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[11]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[12]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[13]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[14]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[15]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[16]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[17]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[18]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[19]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[20]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[21]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[22]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[23]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[24]);
            LightTimeValue.Items.Add(powerConsumptionCalc.types[25]);

        }

        private void ResulPowerButton_Click(object sender, RoutedEventArgs e)
        {
            powerConsumptionCalc.PowerConsumptionCalculate(PriceOfElectricityValue.Text, HeaterValue.Text, HeaterTimeValue.Text, FilterValue.Text, FilterTimeValue.Text, LightValue.Text, LightTimeValue.Text, TypeValue.Text);
            ResultDay.Content = powerConsumptionCalc.resultDay;
            ResultMonth.Content = powerConsumptionCalc.resultMonth;
            ResultYear.Content = powerConsumptionCalc.resultYear;
        }
    }
}
