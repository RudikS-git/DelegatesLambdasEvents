using System;
using CreatingTypes.Task_2;

namespace CreatingTypes
{
    public class SumRows : IStrategy
    {
        public void Sort(int[,] array, Func<int, int, bool> funcOrderSort)
        {
            int[,] arrayClone = (int[,])array.Clone();
            int length ;
            int[] sumRows = SumRowsArray(array, out length);

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if(funcOrderSort(sumRows[i], sumRows[j]))
                    {
                        ArrayHelper.SwapRows(array, i, j, length);
                        ArrayHelper.SwapValues(ref sumRows[i], ref sumRows[j]);
                    }
                }
            }
        }

        private int [] SumRowsArray(int [,] array, out int length)
        {
            length = array.GetLength(0);
            int[] tempArray = new int[array.GetLength(0)];

            for(int i = 0; i<length; i++)
            {
                for(int j = 0; j<length; j++)
                {
                    tempArray[i] += array[i, j];
                }
            }

            return tempArray;
        } 
    }
}
