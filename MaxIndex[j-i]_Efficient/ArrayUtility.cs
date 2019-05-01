using System;
using System.Collections.Generic;
using System.Text;

namespace MaxIndex_j_i__Efficient
{
    public static class ArrayUtility
    {
        public static int[] GetArrayFromUser() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try{
                int arrayLength = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter the elements of the array separated by " +
                    "space, comma or semi-colon");
                String[] elements = Console.ReadLine().Trim().Split(' ', ',', ';');
                array = new int[arrayLength];
                for (int index = 0; index < arrayLength; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return array;
        }

        public static int MaximumIndexInTheArray(int[] array) {
            int arrayLength = array.Length;
            int maxIndexDifference = int.MinValue;

            int[] minElementsHolder = new int[arrayLength];
            int[] maxElementsHolder = new int[arrayLength];

            minElementsHolder[0] = array[0];
            for (int leftToRightIndex = 1; leftToRightIndex < arrayLength; leftToRightIndex++) {
                minElementsHolder[leftToRightIndex] = Math.Min(minElementsHolder[leftToRightIndex - 1], array[leftToRightIndex]);
            }

            maxElementsHolder[arrayLength - 1] = array[arrayLength - 1];
            for (int rightToLeftIndex = arrayLength - 2; rightToLeftIndex >= 0; rightToLeftIndex--) {
                maxElementsHolder[rightToLeftIndex] = Math.Max(array[rightToLeftIndex], maxElementsHolder[rightToLeftIndex+1]);
            }

            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < arrayLength && rightIndex < arrayLength) {
                if (minElementsHolder[leftIndex] < maxElementsHolder[rightIndex])
                {
                    //LeftElement < rightElement -> Calculate maxIndexDifference
                    maxIndexDifference = Math.Max(maxIndexDifference, (rightIndex-leftIndex));
                    //Check whether the next right element is also greater
                    rightIndex++;
                }
                else {
                    leftIndex++;
                }
            }
            return maxIndexDifference;
        }
    }
}
