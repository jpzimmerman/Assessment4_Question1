using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question1 {
    class QuadrotorDrone : Drone {

        public QuadrotorDrone() {}

        public QuadrotorDrone(int totalFlyTime, int totalDistance) : base(totalFlyTime, totalDistance) { }

        public override int FlightSpeed(int totalTime1, int totalDistance1) => AddDistance(totalDistance1) / AddFlightTime(totalTime1);
    }
}
