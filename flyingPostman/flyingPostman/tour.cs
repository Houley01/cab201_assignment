using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyingPostman
{
    class Tour
    {
        public static string currentStationName;
        public static int currentStationXAxis;
        public static int currentStationYAxis;
        public string[] tourStationName;
        public static int indexForTheShortestDistance;

        public static void ChangeCurrentStation(string currentStation, int currentXAxis, int currentYAxis)
        {
            currentStationName = currentStation;
            currentStationXAxis = currentXAxis;
            currentStationYAxis = currentYAxis;
        }

        

        public static double CalculateTheDistanceBetweenPlaces(int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((currentStationXAxis - x2), 2) + Math.Pow((currentStationYAxis - y2), 2));
        }

        public Tour(string stationName)
        {
            tourStationName[stationName.Length + 1] = stationName;
        }
    }
}
