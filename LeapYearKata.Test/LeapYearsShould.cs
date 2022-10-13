using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Test {
    public class LeapYearsShould {
        private LeapYears leapYears;

        [SetUp]
        public void SetUp() {
                leapYears = new LeapYears();
        }

        [TestCase(2017)]
        [TestCase(2018)]
        [TestCase(2019)]
        public void return_false_if_year_is_not_divisible_by_4(int year) {
            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }

        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        public void return_true_if_year_is_divisible_by_4_but_not_by_100(int year) {
            var isLeapYear = leapYears.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }

        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        [TestCase(2100)]
        public void return_false_if_year_is_divisible_by_100_but_not_by_400(int year) {
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