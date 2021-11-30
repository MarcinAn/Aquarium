using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class VolumeCalculate
    {
        public float result;
        public string RactagleVolume(string ractagleHeight, string ractagleWidth, string ractagleDepth)
        {
            float height = ValueParse(ractagleHeight);
            float width = ValueParse(ractagleWidth);
            float depth = ValueParse(ractagleDepth);

            if (height <= 0 || width <= 0 || depth <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                result = (((width * depth) * height) * 0.001f) / 1000f;
                return "Objętość akwarium wynosi: " + Math.Round(result,2) + " l.";
            }
        }

        public string TriangleVolume(string trangleHeight, string trangleWidth, string trangleDepth)
        {
            float height = ValueParse(trangleHeight);
            float width = ValueParse(trangleWidth);
            float depth = ValueParse(trangleDepth);

            if (height <= 0 || width <= 0 || depth <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                result = ((((width * depth)/2) * height) * 0.001f) / 1000f;
                return "Objętość akwarium wynosi: " + Math.Round(result, 2) + " l.";
            }
        }

        public string TrapezeVolume(string trapezeHeight, string trapezeWidthLong, string trapezeWidthShort, string trapezeDepth)
        {
            float height = ValueParse(trapezeHeight);
            float widthLong = ValueParse(trapezeWidthLong);
            float widthShort = ValueParse(trapezeWidthShort);
            float depth = ValueParse(trapezeDepth);

            if (height <= 0 || widthLong <= 0 || widthShort <= 0 || depth <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                result = (((((widthLong+widthShort)*depth)/2)*height)*0.001f)/1000f;
                return "Objętość akwarium wynosi: " + Math.Round(result, 2) + " l.";
            }
        }

        public string PanoramicVolume(string panoramicHeight, string panoramicWidth, string panoramicDepthLong, string panoramicDepthShort)
        {
            float height = ValueParse(panoramicHeight);
            float width = ValueParse(panoramicWidth);
            float depthLong = ValueParse(panoramicDepthLong);
            float depthShort = ValueParse(panoramicDepthShort);

            if (height <= 0 || width <= 0 || depthLong <= 0 || depthShort <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                float squareArea = width * depthShort;
                float ellipticalArea = (float)Math.PI * (width / 2f) * (depthLong - depthShort) / 2f;
                result = (squareArea+ ellipticalArea) * height * 0.001f / 1000f;
                return "Objętość akwarium wynosi: " + Math.Round(result, 2) + " l.";
            }
        }

        public float ValueParse(string stringToParse)
        {
            float resultNumber;

            stringToParse=stringToParse.Replace('.',',');
            if (float.TryParse(stringToParse, out resultNumber))
                return resultNumber;
            else
                return 0;
        }
    }
}
