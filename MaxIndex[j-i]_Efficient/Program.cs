using System;

namespace MaxIndex_j_i__Efficient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum index [j-i] such that element at " +
                "j is greater than element at i!");
            Console.WriteLine("-----------------------------------------" +
                "-------------------------------");

            int[] array = ArrayUtility.GetArrayFromUser();
            Console.WriteLine("The maximum index is "+ArrayUtility.MaximumIndexInTheArray(array));
            Console.ReadLine();

        }
    }
}
