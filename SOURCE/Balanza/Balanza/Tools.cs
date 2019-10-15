using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Balanza
{
    public static class Tools
    {
        public static string DateTimeToSQLiteDate(DateTime d)
        {
            string date = d.Day.ToString() + "/" + d.Month.ToString() + "/" + d.Year.ToString();
            return date;
        }

        public static string DateTimeToSQLiteTime(DateTime d)
        {
            string date = d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString();
            return date;
        }

        public static string DateTimeToSQLiteDateTime(DateTime d)
        {
            string datetime = d.Day.ToString() + "/" + d.Month.ToString() + "/" + d.Year.ToString() + " " + d.Hour.ToString() + ":" + d.Minute.ToString() + ":" + d.Second.ToString(); 
            return datetime;
        }

        public static DateTime SQLiteDateTimeToDateTime(string Date, String Time)
        {
            int day = int.Parse(Date.Split(new char[] {'/'})[0]);
            int month = int.Parse(Date.Split(new char[] { '/' })[1]);
            int year = int.Parse(Date.Split(new char[] { '/' })[2]);
            int hour = int.Parse(Time.Split(new char[] { ':' })[0]);
            int minute = int.Parse(Time.Split(new char[] { ':' })[1]);
            int second = int.Parse(Time.Split(new char[] { ':' })[2]);
            return new DateTime(year, month, day, hour, minute, second);
        }

    }
}
