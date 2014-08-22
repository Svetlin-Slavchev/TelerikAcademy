using System;

// task 8

namespace AcademyPopcorn
{
    public class UnpassableBlock : Block
    {
        public const char Symbol = '$';
        public new const string CollisionGroupString = "unstoppableBlock";

        public UnpassableBlock(MatrixCoords topLeft)
            : base (topLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }

        public override void Update()
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball" || otherCollisionGroupString == "unstoppableBall";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = false;
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
