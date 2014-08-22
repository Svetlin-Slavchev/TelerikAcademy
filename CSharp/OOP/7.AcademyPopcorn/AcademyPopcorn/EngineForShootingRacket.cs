using System;

// task 4
// Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.

namespace AcademyPopcorn
{
    public class EngineForShootingRacket : Engine
    {
        public EngineForShootingRacket(IRenderer renderer, IUserInterface userInterface, int sleepTime)
            : base (renderer, userInterface, sleepTime)
        {
        }

        public void ShootPlayerRacket()
        {
        }
    }
}
