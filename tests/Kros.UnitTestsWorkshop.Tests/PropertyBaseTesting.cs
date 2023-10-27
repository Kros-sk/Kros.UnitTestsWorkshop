using FsCheck;
using FsCheck.Xunit;

namespace Kros.UnitTestsWorkshop.Tests.EShop;

public class PropertyBaseTesting
{
    //[Property]
    //public Property Reverse()
    //{
    //}

    //private static string ReverseText(string text)
    //    => text;

    //[Property(EndSize = int.MaxValue)]
    //public Property PrimeNumberIsNotDivisibleByOtherNumbers(PositiveInt candidate)
    //{
    //}

    //private static bool IsPrime(int number)
    //{
    //    if (number <= 1) return false;
    //    for (int i = 2; i < number; i++)
    //    {
    //        if (number % i == 0) return false;
    //    }
    //    return true;
    //}

    //private static bool IsPrimeFast(int number)
    //{
    //    if (number <= 1) return false;
    //    if (number <= 3) return true;

    //    // Rýchla kontrola
    //    if (number % 2 == 0 || number % 3 == 0) return false;

    //    long i = 5;
    //    while (i * i <= number)
    //    {
    //        if (number % i == 0 || number % (i + 2) == 0)
    //            return false;

    //        i += 6; // Optimalizácia, pretože prvočísla nad 3 sa nachádzajú buď v podobe (6k - 1) alebo (6k + 1).
    //    }
    //    return true;
    //}

    //private int Add(int a, int b)
    //{
    //  return 0;
    //}
}
