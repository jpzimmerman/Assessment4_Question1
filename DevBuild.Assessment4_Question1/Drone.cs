using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment4_Question1 {
    public abstract class Drone {
        int _totalFlyTime;
        int _totalDistance;

        public Drone() {
            _totalFlyTime = 0;
            _totalDistance = 0;
        }

        public Drone(int totalFlyTime, int totalDistance) {
            _totalFlyTime = totalFlyTime;
            _totalDistance = totalDistance;
        }

        public abstract int FlightSpeed(int totalTime, int totalDistance);
        public int AddDistance(int additionalDistance) => _totalDistance += additionalDistance;
        public int AddFlightTime(int additionalTime) => _totalFlyTime += additionalTime;
    }
}
