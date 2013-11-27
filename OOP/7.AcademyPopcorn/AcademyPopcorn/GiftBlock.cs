using System;
using System.Collections.Generic;

// task 12
// Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed.
// You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes
// by adding them through the AcademyPopcornMain.cs file.

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
       // public new const string CollisionGroupString = "block";
        public const char Symbol = 'F';

        public GiftBlock(MatrixCoords topLeft)
            : base (topLeft)
        {
            this.body[0, 0] = GiftBlock.Symbol;
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
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return Block.CollisionGroupString;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed == true)
            {
                List<GameObject> gift = new List<GameObject>();
                gift.Add(new Gift(this.topLeft, new MatrixCoords(1, 0)));
                return gift;
            }
            else
            {
                return new List<GameObject>();
            }
        }
    }
}
