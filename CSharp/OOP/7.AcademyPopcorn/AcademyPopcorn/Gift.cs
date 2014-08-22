using System;
using System.Collections.Generic;

// task 11
// Implement a Gift class. It should be a moving object, which always falls down.
// The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket.
// You must NOT edit any existing .cs file. 

namespace AcademyPopcorn
{
    public class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";
        public const char Symbol = 'V';

        public Gift(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { 'V' } }, speed)
        {
            this.body[0, 0] = Gift.Symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;          
        }

        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (IsDestroyed == true)
            {
                produceObjects.Add(new Bullet(this.topLeft, new MatrixCoords(-1, 0)));
                return produceObjects;
            }
            else
            {
                return new List<GameObject>();
            }            
        }
    }
}
