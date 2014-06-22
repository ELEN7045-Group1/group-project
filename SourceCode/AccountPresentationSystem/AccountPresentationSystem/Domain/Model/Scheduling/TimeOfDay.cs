using NDDDSample.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.Model.Scheduling
{
    public class TimeOfDay : IValueObject<TimeOfDay>
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public TimeOfDay()
        {
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;
        }

        public TimeOfDay(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public TimeOfDay(int SecondInDay)
        {
            Minute = Convert.ToInt32(Math.Truncate(Convert.ToDouble(SecondInDay) / 60));
            Second = SecondInDay % 60;

            Hour = Convert.ToInt32(Math.Truncate(Convert.ToDouble(Minute) / 60));
            Minute = Minute % 60;
        }

        public static TimeOfDay operator +(TimeOfDay t1, TimeOfDay t2)
        {
            int t1Seconds = t1.ToSeconds();
            int t2Seconds = t2.ToSeconds();

            return new TimeOfDay(t1Seconds + t2Seconds);
        }

        public override string ToString()
        {
            DateTimeFormatInfo TimeFormat = new DateTimeFormatInfo();
            return string.Format("{0:00}:{1:00}:{2:00}", this.Hour, this.Minute, this.Second);
            //return string.Concat(string.Format("{0,2}", this.Hour), TimeFormat.TimeSeparator, string.Format("{0,2}", this.Minute), TimeFormat.TimeSeparator, string.Format("{0,2}", this.Second));
        }

        public int ToSeconds()
        {
            return (this.Hour * 60 * 60) + (this.Minute * 60) + this.Second;
        }
        public bool SameValueAs(TimeOfDay other)
        {
            if (other != null)
                if ((other.Minute == this.Minute) &&
                    (other.Hour == this.Hour) &&
                    (other.Second == this.Second))
                    return true;
                else
                    return false;
            else
                return false;
        }
    }
}