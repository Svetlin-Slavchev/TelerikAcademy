using System;

// task 5
// Implement a TrailObject class. It should inherit the GameObject class and should have a constructor
// which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns.
// You must NOT edit any existing .cs file. Then test the TrailObject
// by adding an instance of it in the engine through the AcademyPopcornMain.cs file.

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        public int liveTime;

        public TrailObject(MatrixCoords topLeft, int liveTime)
            : base (topLeft, new char[,] { { '@' } })
        {
            this.liveTime = liveTime;
        }

        public override void Update()
        {
            if (liveTime > 0)
            {
                liveTime--;
            }
            else
            {
                IsDestroyed = true;
            }
        }
    }
}
