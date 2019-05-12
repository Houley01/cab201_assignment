using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyingPostman
{
    class Plane
    {
        private int pRange;
        private int pSpeed;
        private int pTakeOfTime;
        private int pLandingTime;
        private int pRefuelTime;

        public Plane(int range, int speed, int takeOfTime, int landingTime, int RefuelTime) { }

        public int PRange { get => this.pRange; set => this.pRange = value; }
        public int PSpeed { get => this.pSpeed; set => this.pSpeed = value; }
        public int PTakeOfTime { get => pTakeOfTime; set => pTakeOfTime = value; }

        public int PLandingTime { get => pLandingTime; set => pLandingTime = value; }
        public int PRefuelTime { get => pRefuelTime; set => pRefuelTime = value; }

    }
}
