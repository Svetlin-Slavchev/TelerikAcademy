using System;
using System.Collections.Generic;
using System.Linq;

// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

class WithInAndOut
{
    static void Main(string[] args)
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        double centerCircleX = 1;
        double centerCircleY = 1;
        double radiusCircle = 3;
        double RectangleLeftTopX = -1;
        double RectangleLeftTopY = 1;
        double RectangleRightDownX = 6;
        double RectangleRightDownY = -1;

        double resultX = (pointX - centerCircleX)
             * (pointX - centerCircleX);
        double resultY = (pointY - centerCircleY)
             * (pointY - centerCircleY);

        double endResult = resultX + resultY;

        bool ResultCircle = (endResult < radiusCircle * radiusCircle);

        bool ResultRectangle = (pointX < RectangleLeftTopX) || (pointX > RectangleRightDownX)
        || (pointY > RectangleLeftTopY) || (pointY < RectangleRightDownY);

        bool LastResult = (ResultCircle && ResultRectangle);

        Console.WriteLine(LastResult);
    }
}
