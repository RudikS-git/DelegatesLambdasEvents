using System;

namespace CreatingTypes
{
    public class SortContext
    {
        public IStrategy ContextStrategy { private get; set; }

        public SortContext(IStrategy strategy)
        {
            ContextStrategy = strategy;
        }

        public void ExecuteSort(int [,] array, Func<int, int, bool> funcOrderSort)
        {
            ContextStrategy.Sort(array, funcOrderSort);
        }
    }
}
