﻿using System;
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
        public float heaterResult;
        public float filterResult;
        public float consumptioPerDay;
        public float consumptioPerMonth;
        public float consumptioPerYear;
        public string resultDay;
        public string resultMonth;
        public string resultYear;
        public float consumptioPerDaykWh;
        public float consumptioPerMonthkWh;
        public float consumptioPerYearkWh; 
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

            if (typeValue == "zł")
            {
                priceOfElectricityValue = priceOfElectricityValue * 100;
            }


            heaterResult = (float)Math.Round(((heaterValue * 0.001f) * heaterTimeValue),2);
            filterResult = (float)Math.Round(((filterValue * 0.001f) * filterTimeValue), 2);

            consumptioPerDay = ((heaterResult + filterResult) * priceOfElectricityValue)/100;
            consumptioPerDay = (float)Math.Round(consumptioPerDay, 2);
            consumptioPerMonth = consumptioPerDay*30;
            consumptioPerYear= consumptioPerMonth*12;

            consumptioPerDaykWh = heaterResult + filterResult;
            consumptioPerMonthkWh = consumptioPerDaykWh * 30;
            consumptioPerYearkWh = consumptioPerMonthkWh * 12;

            resultDay = "Zużycie za dzień to " + consumptioPerDaykWh + "kWh, co daje " + consumptioPerDay + " zł";
            resultMonth = "Zużycie za miesiąc to " + consumptioPerMonthkWh + "kWh, co daje " + consumptioPerMonth + " zł"; ;
            resultYear = "Zużycie za rok to " + consumptioPerYearkWh + "kWh, co daje " + consumptioPerYear + " zł";
        }
    }
}
