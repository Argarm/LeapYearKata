using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Test {
    public class LeapYearsShould {
        private LeapYears leapYears;

        [SetUp]
        public void SetUp() {
                leapYears = new LeapYears();
        }

        [Test]
        public void return_false_if_year_is_not_divisible_by_4() {
            var year = 2017;

            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }

        [Test]
        public void return_true_if_year_is_divisible_by_4_but_not_by_100() {
            var year = 2008;

            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }
        
        [Test]
        public void return_false_if_year_is_divisible_by_100_but_not_by_400() {
            var year = 1700;

            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }
        
        [Test]
        public void return_true_if_year_is_divisible_by_400() {
            var year = 2000;

            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }
    }
}