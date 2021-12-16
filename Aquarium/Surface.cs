using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Surface
    {
        public float surfaceValue;
        public string surfaceUnitValue;
        public float expectationBottomValue;
        public string expectationBottomUnitValue;
        public string resultUnitValue;
        public float result;


        public List<string> units = new List<string>()
            {
            "mm",
            "cm",
            "m",
            "ml",
            "l"
            };

        public string SurfaceCalculate(string surface, string surfaceUnit, string expectationBottom, string expectationBottomUnit, string resultUnit)
        {
            ValueParser valueParser = new ValueParser();

            surfaceValue = valueParser.ValueParse(surface);
            surfaceUnitValue = surfaceUnit;
            expectationBottomValue = valueParser.ValueParse(expectationBottom); ;
            expectationBottomUnitValue = expectationBottomUnit;
            resultUnitValue = resultUnit;

            if (surfaceValue == 0 || expectationBottomValue == 0)
            {
                return "Błędne dane";
            }

            if (surfaceUnitValue == "mm\u00b2")
            {
                surfaceValue = surfaceValue * 1;
            }
            else if (surfaceUnitValue == "cm\u00b2")
            {
                surfaceValue = surfaceValue * 100;
            }
            else if (surfaceUnitValue == "m\u00b2")
            {
                surfaceValue = surfaceValue * 1000000;
            }
            else
            {
                return "Brak danych";
            }

            if (expectationBottomUnitValue == "mm")
            {
                expectationBottomValue = expectationBottomValue * 1;
            }
            else if (expectationBottomUnitValue == "cm")
            {
                expectationBottomValue = expectationBottomValue * 10;
            }
            else if (expectationBottomUnitValue == "m")
            {
                expectationBottomValue = expectationBottomValue * 1000;
            }
            else
            {
                return "Brak danych";
            }

            result = surfaceValue * expectationBottomValue;

            if (resultUnitValue == "mm\u00b3")
            {
                result = result*1;
            }
            else if (resultUnitValue == "cm\u00b3")
            {
                result= result / 1000;
            }
            else if (resultUnitValue == "m\u00b3")
            {
                result = result / 1000000000;
            }
            else if (resultUnitValue == "ml")
            {
                result = result / 1000;
            }
            else if (resultUnitValue == "l")
            {
                result = result / 1000000;
            }
            else
            {
                return "Brak danych";
            }


            return "Potrzebne jest " + Math.Round(result, 3) + resultUnitValue + " materiału.";
        }
}
}