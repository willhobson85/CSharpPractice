public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool fourHundred = ((year % 400) == 0);
        bool oneHundred = ((year % 100) == 0);
        int lastTwo = (year % 100);
        bool four = ((lastTwo % 4) == 0);
        if ( fourHundred || ( !fourHundred && !oneHundred && four) ) {
            return true;
        } else {
            return false;
        }
    }
}