using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            // "paint" blocks
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 2),
                new MatrixCoords(-1, 1));
            engine.AddObject(theBall);

            //TrailObject trailObject = new TrailObject(new MatrixCoords(4, 4), 3);
            //engine.AddObject(trailObject);

            // Таск 7
            // Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.

            //MeteoriteBall mBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2 + 1, 1), new MatrixCoords(-1, 1), 3);
            //engine.AddObject(mBall);

            // task 9
            // Test the UnpassableBlock and the UnstoppableBall by adding them
            // to the engine in AcademyPopcornMain.cs file

            UnstoppableBall unBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 2),
                new MatrixCoords(-1, 1));
            //engine.AddObject(unBall);

            // "paint" unpassable blocks
            //for (int i = startCol; i < endCol; i++)
            //{
            //    UnpassableBlock currBlockTwo = new UnpassableBlock(new MatrixCoords(startRow + 2, i));

            //    engine.AddObject(currBlockTwo);
            //}

            // task 10
            //for (int i = startCol; i < endCol; i++)
            //{
            //    ExplodingBlock exBlock = new ExplodingBlock(new MatrixCoords(startRow + 2, i));
            //    engine.AddObject(exBlock);
            //}

            // task 11
            Gift gift = new Gift(new MatrixCoords(7, 15), new MatrixCoords(1, 0));
            engine.AddObject(gift);

            // task 12
            GiftBlock giftBlock = new GiftBlock(new MatrixCoords(5, 8));
            engine.AddObject(giftBlock);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            // task 1
            // The AcademyPopcorn class contains an IndestructibleBlock class.
            // Use it to create side and ceiling walls to the game.
            // You can ONLY edit the AcademyPopcornMain.cs file.
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock borderBlockLeft = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(borderBlockLeft);
            }

            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock borderBlockRight = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(borderBlockRight);
            }

            for (int coll = 0; coll < WorldCols; coll++)
            {
                IndestructibleBlock borderBlockRight = new IndestructibleBlock(new MatrixCoords(0, coll));
                engine.AddObject(borderBlockRight);
            }
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 300);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
