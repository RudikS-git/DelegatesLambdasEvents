using System;
using NUnit.Framework;
using CreatingTypes;
using CreatingTypes.Task_2;
using System.Collections.Generic;

namespace CreatingTypesTests
{
    public class Tests
    {
        public static Func<int, int, bool> decrease = (first, second) => first < second;
        public static Func<int, int, bool> increase = (first, second) => first > second;


        static public IEnumerable<TestCaseData> combination_tests()
        {
            yield return new TestCaseData(new int[,] { { 6, 2, 2 }, { 2, 10, 1 }, { 7, 3, 9 } },
                                          new MaxMinOfRow(TypeSort.Min),
                                          decrease,
                                          new int[,] { { 7, 3, 9 }, { 6, 2, 2 }, { 2, 10, 1 } }).SetName("test 1"); ;

            yield return new TestCaseData(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                                            new MaxMinOfRow(TypeSort.Max),
                                            increase,
                                            new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }).SetName("test 2"); ;

            yield return new TestCaseData(new int[,] { { 2, 2, 8 }, { 1, 3, 7 }, { 0, 0, 5 } },
                                          new SumRows(),
                                          increase,
                                          new int[,] { { 0, 0, 5 }, { 1, 3, 7 }, { 2, 2, 8 } }).SetName("test 3");

            yield return new TestCaseData(new int[,] { { 9, 2, 8 }, { 1, 3, 7 }, { 0, 0, 5 } },
                                          new SumRows(),
                                          decrease,
                                          new int[,] { { 9, 2, 8 }, { 1, 3, 7 }, { 0, 0, 5 } }).SetName("test 4");

            yield return new TestCaseData(new int[,] { { 9, 4, 4 }, { 3, 12, 0 }, { 8, 2, 10 } },
                                          new MaxMinOfRow(TypeSort.Min),
                                          decrease,
                                          new int[,] { { 9, 4, 4 }, { 8, 2, 10 }, { 3, 12, 0 } }).SetName("test 5"); ;
        }

        [TestCaseSource("combination_tests")]
        public void Sort_Tests(int [,] array, IStrategy strategy, Func<int, int, bool> funcOrderSort, int[,] expectedArray)
        {
            SortContext sortContext = new SortContext(strategy);
            sortContext.ExecuteSort(array, funcOrderSort);
            Assert.AreEqual(array, expectedArray);
        }
    }
}