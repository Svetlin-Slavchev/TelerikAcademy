using System;

// additional class to task 10

namespace AcademyPopcorn
{
    public class Explosion : MovingObject
    {
        public Explosion(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { {'!'} }, speed)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return true;
        }
        public override void Update()
        {
            this.IsDestroyed = true;
        }
    }
}
