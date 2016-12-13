using System;

namespace MinElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = Find(5, 6, 8, 8, 9, 10, 1, 2, 3);
            Console.WriteLine("Min value: {0}", min);
            Console.ReadLine();
        }

        private static int Find(params int[] a)
        {
            Console.WriteLine("Длинна массива: {0}", a.Length);

            int averageIndex = 0; // переменная для хранения индекса среднего элемента массива
            int firstIndex = 0; // индекс первого элемента в массиве
            int lastIndex = a.Length - 1; // индекс последнего элемента в массиве
            int searchValue = 0; // искомое (ключевое) значение

            while(true)
            {
                averageIndex = firstIndex + (lastIndex - firstIndex) / 2; // меняем индекс среднего значения

                if (a[firstIndex] <= a[averageIndex])
                {
                    if ((firstIndex > 0 && a[firstIndex] < a[averageIndex + 1]) || firstIndex == averageIndex)
                    {
                        searchValue = a[firstIndex];
                        break;
                    }

                    firstIndex = averageIndex + 1;
                }
                else
                {
                    if ( averageIndex + 1 == lastIndex)
                    {
                        if (a[averageIndex] < a[lastIndex])
                        {
                            searchValue = a[averageIndex];
                            break;
                        }

                        searchValue = a[lastIndex];
                        break;
                    }

                    lastIndex = averageIndex;
                }
            }

            return searchValue;
        }
    }
}

//while(true)
//            {
//                averageIndex = firstIndex + (lastIndex - firstIndex) / 2; // меняем индекс среднего значения

//                if (a[firstIndex] < a[averageIndex])
//                {
//                    if (!(a[averageIndex + 1] < a[lastIndex]))
//                    {
//                        if (averageIndex + 1 == lastIndex)
//                        {
//                            searchValue = a[lastIndex];
//                            break;
//                        }
//                        firstIndex = averageIndex + 1;
//                    }
//                    else
//                    {
//                        searchValue = a[averageIndex + 1];
//                        break;
//                    }
//                }
//                else
//                {
//                    if (averageIndex + 1 == lastIndex)
//                    {
//                        searchValue = a[lastIndex];
//                        break;
//                    }
//                    lastIndex = averageIndex;
//                }
//            }