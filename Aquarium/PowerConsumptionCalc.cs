using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class PowerConsumptionCalc
    {
        public float priceOfElectricityValue;
        public float heaterValue;
        public float filterValue;
        public string typeValue;
        public float heaterTimeValue;
        public float filterTimeValue;
        public List<string> types = new List<string>()
    {
        "zł",
        "gr",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
    };

        public void PowerConsumptionCalculate(string priceOfElectricity, string heater, string heaterTime, string filter, string filterTime, string type)
        {
            ValueParser valueParser = new ValueParser();
            priceOfElectricityValue = valueParser.ValueParse(priceOfElectricity);
            heaterValue = valueParser.ValueParse(heater);
            filterValue = valueParser.ValueParse(filter);
            typeValue = type;
            heaterTimeValue = valueParser.ValueParse(heaterTime);
            filterTimeValue = valueParser.ValueParse(filterTime);


        }
    }
}
