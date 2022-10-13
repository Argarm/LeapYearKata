using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Test {
    public class LeapYearsShould {

        [Test]
        public void return_false_if_year_is_not_divisible_by_4() {
            var leapYears = new LeapYears();
            var year = 2017;

            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }
    }
}