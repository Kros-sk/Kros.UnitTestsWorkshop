using FsCheck;
using FsCheck.Xunit;

namespace Kros.UnitTestsWorkshop.Tests.EShop;

public class PropertyBaseTesting
{
    // [Theory]
    // [InlineData(null, null)]
    // [InlineData(new[] { 1 }, new[] { 1 })]
    // [InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
    // [InlineData(new[] { 2, 1, 3 }, new[] { 1, 2, 3 })]
    // [InlineData(new[] { 2, 1, 3, 5, 4 }, new[] { 1, 2, 3, 4, 5 })]
    // public void BubbleSort_Should_Sort_Array_Correctly(int[]? input, int[]? expectedOutput)
    // {
    //     var result = SortingAlgorithm.MergeSort(input);
    //     result.Should().Equal(expectedOutput);
    // }

    // [Property(EndSize = int.MaxValue)]
    // public Property PrimeNumberIsNotDivisibleByOtherNumbers(PositiveInt candidate)
    // {
    // }

    // private static bool IsPrime(int number)
    // {
    //     if (number <= 1)
    //     {
    //         return false;
    //     }
    //     for (int i = 2; i < number; i++)
    //     {
    //         if (number % i == 0)
    //         {
    //             return false;
    //         }
    //     }
    //     return true;
    // }

    // private static bool IsPrimeFast(int number)
    // {
    //     if (number <= 1)
    //     {
    //         return false;
    //     }
    //     if (number <= 3)
    //     {
    //         return true;
    //     }

    //     // Rýchla kontrola
    //     if (number % 2 == 0 || number % 3 == 0)
    //     {
    //         return false;
    //     }

    //     long i = 5;
    //     while (i * i <= number)
    //     {
    //         if (number % i == 0 || number % (i + 2) == 0)
    //         {
    //             return false;
    //         }

    //         i += 6; // Optimalizácia, pretože prvočísla nad 3 sa nachádzajú buď v podobe (6k - 1) alebo (6k + 1).
    //     }
    //     return true;
    // }

    // private int Add(int a, int b)
    // {
    //     return 0;
    // }

    // private static bool IsSorted(IEnumerable<int>? sequence)
    // {
    //     if (sequence is null)
    //     {
    //         return true;
    //     }

    //     var array = sequence.ToArray();
    //     for (int i = 0; i < array.Length - 1; i++)
    //     {
    //         if (array[i] > array[i + 1])
    //         {
    //             return false;
    //         }
    //     }
    //     return true;
    // }

    // public static class SortingAlgorithm
    // {
    //     public static IEnumerable<int>? MergeSort(IEnumerable<int>? input)
    //     {
    //         if (input is null)
    //         {
    //             return null;
    //         }

    //         var numbers = input.ToList();
    //         if (numbers.Count <= 1)
    //         {
    //             return numbers;
    //         }

    //         var middle = numbers.Count / 2;
    //         var left = MergeSort(numbers.GetRange(0, middle))!;
    //         var right = MergeSort(numbers.GetRange(middle, numbers.Count - middle))!;

    //         return Merge(left, right);
    //     }

    //     private static IEnumerable<int> Merge(IEnumerable<int> left, IEnumerable<int> right)
    //     {
    //         var leftEnumerator = left.GetEnumerator();
    //         var rightEnumerator = right.GetEnumerator();
    //         var leftHasNext = leftEnumerator.MoveNext();
    //         var rightHasNext = rightEnumerator.MoveNext();

    //         while (leftHasNext || rightHasNext)
    //         {
    //             if (!leftHasNext)
    //             {
    //                 yield return rightEnumerator.Current;
    //                 rightHasNext = rightEnumerator.MoveNext();
    //             }
    //             else if (!rightHasNext)
    //             {
    //                 yield return leftEnumerator.Current;
    //                 leftHasNext = leftEnumerator.MoveNext();
    //             }
    //             else if (leftEnumerator.Current < rightEnumerator.Current)
    //             {
    //                 yield return leftEnumerator.Current;
    //                 leftHasNext = leftEnumerator.MoveNext();
    //             }
    //             else
    //             {
    //                 yield return rightEnumerator.Current;
    //                 rightHasNext = rightEnumerator.MoveNext();
    //             }
    //         }
    //     }
    // }
}
