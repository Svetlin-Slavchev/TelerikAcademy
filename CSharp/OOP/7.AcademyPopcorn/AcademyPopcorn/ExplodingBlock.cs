using System;
using System.Collections.Generic;

// task 10
// Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed.
// You must NOT edit any existing .cs file.
// Hint: what does an explosion "produce"?

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public const char Symbol = '*';

        public ExplodingBlock(MatrixCoords topLeft)
            : base (topLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }

        public override void Update()
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return ExplodingBlock.CollisionGroupString;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Explosion> exBlocks = new List<Explosion>();
            if (this.IsDestroyed == true)
            {
                exBlocks.Add(new Explosion(this.topLeft, new MatrixCoords(0, 1)));
                exBlocks.Add(new Explosion(this.topLeft, new MatrixCoords(0, -1)));
            }
            return exBlocks;
        }
    }
}
