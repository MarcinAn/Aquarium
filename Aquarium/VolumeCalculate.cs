using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class VolumeCalculate
    {
        public float capacity;
        public float bottomSurface;
        ValueParser valueParser = new ValueParser();
        public string RactagleVolume(string ractagleHeight, string ractagleWidth, string ractagleDepth)
        {
            float height = valueParser.ValueParse(ractagleHeight);
            float width = valueParser.ValueParse(ractagleWidth);
            float depth = valueParser.ValueParse(ractagleDepth);

            if (height <= 0 || width <= 0 || depth <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                bottomSurface = width * depth;
                capacity = ((bottomSurface * height) * 0.001f) / 1000f;
                return "Objętość akwarium wynosi: " + Math.Round(capacity, 1) + " l. Powierzchnia dna to " + surfaceUnits(bottomSurface);
            }
        }

        public string TriangleVolume(string trangleHeight, string trangleWidth, string trangleDepth)
        {
            float height = valueParser.ValueParse(trangleHeight);
            float width = valueParser.ValueParse(trangleWidth);
            float depth = valueParser.ValueParse(trangleDepth);

            if (height <= 0 || width <= 0 || depth <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                bottomSurface= (width * depth) / 2;
                capacity = ((bottomSurface * height) * 0.001f) / 1000f;
                return "Objętość akwarium wynosi: " + Math.Round(capacity, 1) + " l. Powierzchnia dna to " + surfaceUnits(bottomSurface);
            }
        }

        public string TrapezeVolume(string trapezeHeight, string trapezeWidthLong, string trapezeWidthShort, string trapezeDepth)
        {
            float height = valueParser.ValueParse(trapezeHeight);
            float widthLong = valueParser.ValueParse(trapezeWidthLong);
            float widthShort = valueParser.ValueParse(trapezeWidthShort);
            float depth = valueParser.ValueParse(trapezeDepth);

            if (height <= 0 || widthLong <= 0 || widthShort <= 0 || depth <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                bottomSurface = ((widthLong + widthShort) * depth) / 2;
                capacity = ((bottomSurface * height)*0.001f)/1000f;
                return "Objętość akwarium wynosi: " + Math.Round(capacity, 1) + " l. Powierzchnia dna to " + surfaceUnits(bottomSurface);
            }
        }

        public string PanoramicVolume(string panoramicHeight, string panoramicWidth, string panoramicDepthLong, string panoramicDepthShort)
        {
            float height = valueParser.ValueParse(panoramicHeight);
            float width = valueParser.ValueParse(panoramicWidth);
            float depthLong = valueParser.ValueParse(panoramicDepthLong);
            float depthShort = valueParser.ValueParse(panoramicDepthShort);

            if (height <= 0 || width <= 0 || depthLong <= 0 || depthShort <= 0)
            {
                return "Wprowadzono błędne dane!";
            }
            else
            {
                float squareArea = width * depthShort;
                float ellipticalArea = (float)Math.PI * (width / 2f) * (depthLong - depthShort) / 2f;
                bottomSurface = squareArea + ellipticalArea;
                capacity = bottomSurface * height * 0.001f / 1000f;
                return "Objętość akwarium wynosi: " + Math.Round(capacity, 1) + " l. Powierzchnia dna to " + surfaceUnits(bottomSurface);
            }
        }

        public string surfaceUnits(float bottomSurface)
        {
            if (bottomSurface < 100)
            {
                bottomSurface = (float)Math.Round(bottomSurface, 1);
                return bottomSurface + "mm\u00b2";
            }
            else if (bottomSurface >= 100 && bottomSurface < 1000000)
            {
                bottomSurface = (float)Math.Round(bottomSurface / 100, 1);
                return bottomSurface + "cm\u00b2";
            }
            else if (bottomSurface >= 1000000)
            {
                bottomSurface = (float)Math.Round(bottomSurface / 1000000, 1);
                return bottomSurface + "m\u00b2";
            }
            else
            {
                return "0";
            }
        }
    }
}
