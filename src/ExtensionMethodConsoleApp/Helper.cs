using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodConsoleApp.Extensions;

internal static class DateTimeHelper
{
    // Metoda rozszerzajaca
    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }

    public static DateTime AddWorkDays(this DateTime date, int days)
    {
        return date.AddDays(days);
    }
}

// C# 14 (.NET 10)
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14#extension-members
/*
internal static class DateTimeExtensions
{
    extension(DateTime date)
    {
        // Metoda rozszerzajaca
        public static bool IsWeekend()
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static DateTime AddWorkDays(int days)
        {
            return date.AddDays(days);
        }
    }
}

*/