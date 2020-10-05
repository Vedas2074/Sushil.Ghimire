using System;
namespace AccessModifiersAndMethd
{


    internal class AccessModifiers
    {
        internal int x;
        public int y;
        internal void DoSomething()
        {

        }
        public int CalculateAverage(int[] numbers)
        {
            DoSomething();
            //calculate average
            return 0;
        }
    }
}