using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #region Constructor
        public Duration(int hours, int minutes, int seconds)
        {
            if (hours < 0 || minutes < 0 || seconds < 0)
            {
                throw new ArgumentException("Hours, minutes, and seconds must be non-negative.");
            }
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            //for Handel case addition
            CalcTime();

        }
        public Duration(int totalSeconds)
        {
            if (totalSeconds < 0)
            {
                throw new ArgumentException("Total seconds must be non-negative.");
            }
            Hours = 0;
            Minutes = 0;
            Seconds = totalSeconds;
            CalcTime();
        }

        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Hours: {Hours}\nMinutes: {Minutes}\nSeconds: {Seconds}";
        }
       
        public override bool Equals(object obj)
        {
            if (obj is Duration other && obj is not null)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return  (int) (Hours + Minutes + Seconds);
        }
        private void CalcTime()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }
        #endregion
        #region OperatorOverloading
        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration(D1.Hours + D2.Hours, D1.Minutes + D2.Minutes, D1.Seconds + D2.Seconds);
        }

        public static Duration operator +(Duration D1, int seconds)
        {
            return new Duration(D1.Hours, D1.Minutes, D1.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration d1)
        {
            return d1 + seconds;
        }
        public static Duration operator -(Duration d1, Duration D2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds;
            return new Duration(Math.Max(0, totalSeconds1 - totalSeconds2));
        }

        public static Duration operator ++(Duration d)
        {
            return d + 60;
        }

        public static Duration operator --(Duration D)
        {
            int totalSeconds = D.Hours * 3600 + D.Minutes * 60 + D.Seconds - 60;
            return new Duration(Math.Max(0, totalSeconds));
        }
        public static bool operator >(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) > (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }

        public static bool operator <(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) < (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }

        public static bool operator >=(Duration D1, Duration D2)
        {
            return !(D1 < D2);
        }

        public static bool operator <=(Duration D1, Duration D2)
        {
            return !(D1 > D2);
        }
        public static implicit operator bool(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }

       
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

        #endregion
    }
}
