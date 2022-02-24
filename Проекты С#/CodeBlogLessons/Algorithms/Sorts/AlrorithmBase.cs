using System;

namespace Algorithms
{
    abstract class AlgorithmBase
    {
        protected private void Swap(int argA, int argB, int[] array)
        {
            int temp;
            int count = array.Length;

            if(argA < count && argB < count)
            {
                temp = array[argA];
                array[argA] = array[argB];
                array[argB] = temp;
            }
        }
    }
}
