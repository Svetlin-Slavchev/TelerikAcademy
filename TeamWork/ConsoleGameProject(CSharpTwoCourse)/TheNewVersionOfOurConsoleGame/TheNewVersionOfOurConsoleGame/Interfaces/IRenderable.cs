using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNewVersionOfOurConsoleGame.Interfaces
{
    public interface IRenderable
    {
        void Render(int coordinateX, int coordinateY, int[,] matrix, int matrixDimention);
    }
}
