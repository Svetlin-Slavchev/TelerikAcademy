using System;

// task 8
// Implement an UnstoppableBall and an UnpassableBlock.
// The UnstopableBall only bounces off UnpassableBlocks and will destroy any other block it passes through.
// The UnpassableBlock should be indestructible. Hint: Take a look at the RespondToCollision method,
// the GetCollisionGroupString method and the CollisionData class.

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base (topLeft, speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unstoppableBlock";
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            base.RespondToCollision(collisionData);
        }
    }
}
