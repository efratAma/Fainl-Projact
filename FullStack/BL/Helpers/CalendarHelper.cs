using FullStack.api;
using System;
using System.Collections.Generic;
using System.Globalization;

public class CalendarHelper
{
    private static HebrewCalendar hebrewCalendar = new HebrewCalendar();
    dbClass dbClass;
    public CalendarHelper(dbClass _dbClass)
    {
        dbClass= _dbClass;
    }

    public static List<DateTime> GetWorkingDays(DateTime startDate, DateTime endDate)
    {
        var result = new List<DateTime>();

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (IsShabbat(date) || IsJewishHoliday(date))
                continue;

            result.Add(date);
        }

        return result;
    }

    private static bool IsShabbat(DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday;
    }

    private static bool IsJewishHoliday(DateTime date)
    {
        int day = hebrewCalendar.GetDayOfMonth(date);
        int month = hebrewCalendar.GetMonth(date);

        // דוגמה לחגים (ללא תוספות של חול המועד או ערבי חג):
        return
            (month == 1 && day == 1) ||  // ראש השנה
            (month == 1 && day == 10) || // יום כיפור
            (month == 1 && day == 15) || // סוכות
            (month == 3 && day == 14) || // פורים
            (month == 7 && day == 15);   // פסח
    }
}
