using System;

namespace TAFEEnrollmentSystem.Utility
{
    public static class SearchUtility
    {
        /// <summary>
        /// Performs a linear search.
        /// 
        /// Pseudocode:
        /// Set index i = 0
        /// Set found = false
        /// While found = false AND i < array length
        /// Compare criteria with element at index i
        /// If equal
        /// Set found = true
        /// Else
        /// Increse i
        /// If i < array length
        /// Return i
        /// Else
        /// Return -1
        /// </summary>

        
        public static int LinearSearchArray<T>(T[] myArray, T criteria) where T : IComparable<T>
        {
            try
            {
                // check if array is null
                if (myArray == null)
                {
                    throw new ArgumentNullException(nameof(myArray),"Array cannot be null.");
                }

                // check if array is empty
                if (myArray.Length == 0)
                {
                    throw new ArgumentException("Array cannot be empty.");
                }

                // check if criteria is null
                if (criteria == null)
                {
                    throw new ArgumentNullException(nameof(criteria),"Search criteria cannot be null.");
                }
                int i = 0;
                bool found = false;

                while (!found && i < myArray.Length) // while not found and not end of array
                {
                    if (criteria.CompareTo(myArray[i]) == 0)
                        found = true;
                    else
                        i++; // move to next element
                }

                if (i < myArray.Length)
                {
                    return i; // return index if found
                }
                else
                {
                    return -1; // return -1 if not found
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        /// <summary>
        /// Performs binary search on a sorted array.
        /// 
        /// Pseudocode:
        /// Set min = 0, max = length - 1
        /// While min <= max:
        /// Find mid
        /// Compare mid with target
        /// If equal  
        /// return index
        /// If mid < target  
        /// search right
        /// Else  
        /// search left
        /// Return -1 if not found
        /// </summary>
        public static int BinarySearchArray<T>(T[] myArray, T criteria) where T : IComparable<T>
        {
            try
            {
                // check if array is null
                if (myArray == null)
                {
                    throw new ArgumentNullException(nameof(myArray),"Array cannot be null.");
                }

                // check if array is empty
                if (myArray.Length == 0)
                {
                    throw new ArgumentException("Array cannot be empty.");
                }

                // check if criteria is null
                if (criteria == null)
                {
                    throw new ArgumentNullException(nameof(criteria),"Search criteria cannot be null.");
                }
                int min = 0;
                int max = myArray.Length - 1;
                int mid;

                do
                {
                    mid = (min + max) / 2;

                    if (myArray[mid].CompareTo(criteria) == 0) // found
                        return mid;

                    if (criteria.CompareTo(myArray[mid]) > 0) // criteria > myArray[mid]
                        min = mid + 1; // search right half
                    else
                        max = mid - 1; // search left half

                } while (min <= max);

                return -1; // not found
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// Performs Bubble Sort in ascending order.
        /// 
        /// Pseudocode:
        /// 1. Loop through array (outer loop)
        /// 2. Compare adjacent elements
        /// 3. Swap if left > right
        /// 4. Repeat until sorted
        /// </summary>
        public static void BubbleSortAscending<T>(T[] numbers) where T : IComparable<T>
        {
            T temp;

            for (int j = 0; j < numbers.Length - 1; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i].CompareTo(numbers[i + 1]) > 0)
                    {
                        // swap the elements
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Performs Bubble Sort in descending order.
        /// 
        /// Pseudocode:
        /// 1. Loop through array (outer loop)
        /// 2. Compare adjacent elements
        /// 3. Swap if left < right
        /// 4. Repeat until sorted
        /// </summary>
        public static void BubbleSortDescending<T>(T[] numbers) where T : IComparable<T>
        {
            T temp;

            for (int j = 0; j < numbers.Length - 1; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i].CompareTo(numbers[i + 1]) < 0)
                    {
                        // swap the elements
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
        }
    }    
}