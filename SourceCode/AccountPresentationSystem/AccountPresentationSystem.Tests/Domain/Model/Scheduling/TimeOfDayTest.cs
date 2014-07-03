using AccountPresentationSystem.Domain.Model.Scheduling;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationSystem.Tests.Domain.Model.Schedule
{
    [TestFixture]
    public class TimeOfDayTest
    {
        [Test]
        public void TimeOfDayFromSecondOfDayTest()
        {
            //Arange
            int TimeInDay = 15870;
            TimeOfDay CompareTime = new TimeOfDay(4,24,30);

            //Act
            TimeOfDay TestTime = new TimeOfDay(TimeInDay);

            //Assert
            Assert.AreEqual(CompareTime.Hour, TestTime.Hour);
            Assert.AreEqual(CompareTime.Minute, TestTime.Minute);
            Assert.AreEqual(CompareTime.Second, TestTime.Second);
        }

        [Test]
        public void TimeOfDayAddition()
        {
            //Arange
            TimeOfDay Time1 = new TimeOfDay(4, 24, 30);
            TimeOfDay Time2 = new TimeOfDay(4, 46, 40);

            //Act
            TimeOfDay NewTime = Time1 + Time2;

            //Assert
            Assert.AreEqual(NewTime.Hour, 9);
            Assert.AreEqual(NewTime.Minute, 11);
            Assert.AreEqual(NewTime.Second, 10);
        }

        [Test]
        public void TimeOfDayGreaterThan()
        {
            //Arange
            TimeOfDay Time1 = new TimeOfDay(4, 55, 30);
            TimeOfDay Time2 = new TimeOfDay(4, 46, 40);

            //Act
            bool IsGreater = Time1 > Time2;

            //Assert
            Assert.IsTrue(IsGreater);
        }

        [Test]
        public void TimeOfDayLessThan()
        {
            //Arange
            TimeOfDay Time1 = new TimeOfDay(4, 35, 30);
            TimeOfDay Time2 = new TimeOfDay(4, 46, 40);

            //Act
            bool IsGreater = Time1 < Time2;

            //Assert
            Assert.IsTrue(IsGreater);
        }
    }
}
