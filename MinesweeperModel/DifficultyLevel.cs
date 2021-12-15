using System.Drawing;

namespace MinesweeperModel
{
    public enum DifficultyLevel
    {
        Easy, // 10 x 8
        Medium,// 
        Hard
    }

    public static class Extensions
    {
        public static Point GetSize(this DifficultyLevel dl )
        {
            switch (dl)
            {
                case DifficultyLevel.Easy:
                default:
                    return new Point { X = 10, Y = 8 };
            }
        }
    }
}