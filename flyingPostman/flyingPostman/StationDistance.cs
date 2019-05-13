using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyingPostman
{
    class StationDistance
    {
        private string stationName;
        private double distanceBetweenStation;
        public StationDistance(string stationName, double distanceBetweenStation)
        {
            testStationName = stationName;
            testDistanceBetweenStation = distanceBetweenStation;
        }

        public string testStationName { get => stationName; set => stationName = value; }
        public double testDistanceBetweenStation { get => distanceBetweenStation; set => distanceBetweenStation = value; }
    }
}
