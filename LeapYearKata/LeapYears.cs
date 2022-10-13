namespace LeapYearKata
{
    public class LeapYears {
        public bool IsLeapYear(int year) {
            if(year % 4 != 0) return false;
            return true;
        }
    }
}