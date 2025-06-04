using Dal.models;
using FullStack.api;
using HebrewCalendar;
using System.Globalization;

namespace Dal.Services
{
    public class QueueService
    {
        private readonly dbClass _context;

        public readonly TimeOnly workStart = new TimeOnly(9, 0);
        public readonly TimeOnly workEnd = new TimeOnly(19, 0);
        public readonly TimeOnly breakStart = new TimeOnly(14, 0);
        public readonly TimeOnly breakEnd = new TimeOnly(16, 0);
        public QueueService(dbClass context)
        {
            _context = context;
        }

        public void FillQueueList(string optometristId, bool available)
        {
            ClearExistingQueues(optometristId);

            DateTime startDate = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, 12, 31);

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (ShouldSkipDate(date)) continue;

                AddDailyAppointments(date, optometristId, available);
            }

            _context.SaveChanges();
        }

        private void ClearExistingQueues(string optometristId)
        {
            var existingQueues = _context.QueueLists
                .Where(q => q.OptometrisId == optometristId)
                .ToList();

            if (existingQueues.Any())
            {
                _context.QueueLists.RemoveRange(existingQueues);
            }
        }

        private bool ShouldSkipDate(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Friday ||
                   date.DayOfWeek == DayOfWeek.Saturday ||
                   IsHoliday(date);
        }

        private void AddDailyAppointments(DateTime date, string optometristId, bool available)
        {

            for (TimeOnly time = workStart; time < workEnd; time = time.AddMinutes(30))
            {
                if (time >= breakStart && time < breakEnd)
                    continue;

                var queue = new QueueList(
                    DateOnly.FromDateTime(date),
                    time,
                    available,
                    optometristId
                );

                _context.QueueLists.Add(queue);
            }
        }

        private bool IsHoliday(DateTime date)
        {
            HebrewCalendar2 hebCal = new();

            // נשתמש בגרסה שמחזירה את התאריך העברי המלא עבור תאריך נתון
            string formattedDate = hebCal.GetDate(date); // מחזיר לדוגמה: יום ראשון, ג' חשון תשפ"ג

            string[] holidays = new[]
            {"יום כיפור", "ראש השנה","סוכות","שמחת תורה","שבועות", "פסח"};

            foreach (var holiday in holidays)
            {
                if (formattedDate.Contains(holiday) || formattedDate.Contains("תענית"))
                    return true;
            }

            return false;
        }

    }
}