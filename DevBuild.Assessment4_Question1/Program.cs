using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question1 {
    class Program {
        static void Main(string[] args) {
            var distanceSettingInFeet = 300;
            var flightTimeSettingInMinutes = 15;

            QuadrotorDrone myDrone = new QuadrotorDrone(flightTimeSettingInMinutes, distanceSettingInFeet);
            Console.WriteLine($"I am a {myDrone.GetType().Name} that flew {distanceSettingInFeet} feet in {flightTimeSettingInMinutes} minute(s).");
            Console.WriteLine($"My flight speed was {myDrone.FlightSpeed(0, 0)} feet per minute.");

            while (true) { }
        }
    }
}
