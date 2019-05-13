using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace flyingPostman
{
    class Program
    {
        static void Main(string[] args)
        {

            // ThingsToDoWithFiles.CheckNumberOfArguments(args);
            if (ThingsToDoWithFiles.CheckFilesExist(args) == true)
            {
                // Read Mail file
                string[] mailStops = ThingsToDoWithFiles.ReadFile(args[0]);
                List<Station> stationList = new List<Station>();
                for (int index = 0; index < mailStops.Length; index += 3)
                {
                    Station x = new Station(mailStops[index], int.Parse(mailStops[index + 1]), int.Parse(mailStops[index + 2]));
                    stationList.Add(x);
                }

                // Set the current station to Post Office
                Tour.ChangeCurrentStation(stationList[0].Sname, stationList[0].SxAxis, stationList[0].SyAxis);
                stationList.Remove(stationList[0]);

                //foreach (Station station in stationList)
                //{
                //    Console.WriteLine("station: {0}, x: {1}, y: {2} ", station.Sname, station.SxAxis, station.SyAxis);
                //}

                // Read the plane file
                string[] planeSpecs = ThingsToDoWithFiles.ReadFile(args[1]);
                Plane planeInUse = new Plane(int.Parse(planeSpecs[0]), int.Parse(planeSpecs[1]), int.Parse(planeSpecs[2]),
                                             int.Parse(planeSpecs[3]), int.Parse(planeSpecs[4]));
                int listItemToBeRemoved=0;
                void FindTheshortestDistance()
                {
                    double compareDistance = 9999999999;
                    double testCompareDistance;
                        for (int index = 0; index < stationList.Count; index++)
                        {
                            testCompareDistance = Tour.CalculateTheDistanceBetweenPlaces(stationList[index].SxAxis, stationList[index].SyAxis);
                            if (compareDistance > testCompareDistance)
                            {
                                compareDistance = testCompareDistance;
                                listItemToBeRemoved = index;
                            }
                    }
                        Console.WriteLine("{0}, {1}, {2}", stationList[listItemToBeRemoved].Sname, stationList[listItemToBeRemoved].SxAxis, stationList[listItemToBeRemoved].SyAxis);
                    Tour.ChangeCurrentStation(stationList[listItemToBeRemoved].Sname, stationList[listItemToBeRemoved].SxAxis, stationList[listItemToBeRemoved].SyAxis);
                        stationList.Remove(stationList[listItemToBeRemoved]);
                    if (stationList.Count >= 1)
                    {
                        FindTheshortestDistance();
                    }

                } // End of FindTheshortestDistance

                FindTheshortestDistance();
            }



            if (ThingsToDoWithFiles.CheckFilesExist(args) == false)
            {
                Console.WriteLine("one or more files do not exist");
            }
            Console.ReadKey();
        } // End of Main
    }
}
