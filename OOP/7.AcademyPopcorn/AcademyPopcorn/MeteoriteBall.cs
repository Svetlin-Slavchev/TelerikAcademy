using System;
using System.Collections.Generic;

// task 6
// Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects.
// Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way
// as the normal ball. You must NOT edit any existing .cs file.

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public int liveTime;

        public MeteoriteBall(MatrixCoords topleft, MatrixCoords speed, int liveTime)
            : base (topleft, speed)
        {
            this.liveTime = liveTime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> produceObjects = new List<TrailObject>();
            produceObjects.Add(new TrailObject(this.topLeft, liveTime));
            return produceObjects;
        }

        public override void Update()
        {
            if (liveTime >= 0)
            {
                liveTime--;
            }
            this.UpdatePosition();
        }
    }
}
