using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class ValueParser
    {
        public float ValueParse(string stringToParse)
        {
            float resultNumber;

            stringToParse = stringToParse.Replace('.', ',');
            if (float.TryParse(stringToParse, out resultNumber))
                return resultNumber;
            else
                return 0;
        }
    }
}
