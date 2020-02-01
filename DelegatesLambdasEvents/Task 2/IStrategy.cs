using System;

namespace CreatingTypes
{
    public interface IStrategy
    {
        void Sort(int[,] array, Func<int, int, bool> funcOrderSort);
    }
}
