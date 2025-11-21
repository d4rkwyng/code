/**
 * CIS12  Asg5
 * Date.java
 * Purpose: Displays the proper date.
 *
 * @author Derek Wood
 * @version 1.0 10/15/02
 *          1.1 10/16/02
 *          1.2 10/20/02
 */

public class Date
{
   /**
    * Allows you to test a date to see if it's valid.  Date must be imple-
    * mented in a Test class file.
    */
    public final static int
    // Collection of instance variables (Monthes)
        JAN = 1, FEB = 2, MAR = 3,
        APR = 4, MAY = 5, JUN = 6,
        JUL = 7, AUG = 8, SEP = 9,
        OCT = 10, NOV = 11, DEC = 12;

    // More Instance variables
    private int year;
    private int month;
    private int day;

    // Default Constructor
    public Date() { }

    // Overload Constructor; @param newYear; newMonth, newDay
    public Date(int newYear, int newMonth, int newDay)
    {
        year = newYear;
        month = newMonth;
        day = newDay;
    }
    // returns year
    public int getYear()
    {
        return year;
    }
    // returns month
    public int getMonth()
    {
        return month;
    }
    // returns day
    public int getDay()
    {
        return day;
    }

    // sets year
    public void setYear(int newYear)
    {
        year = newYear;
    }
    // sets month
    public void setMonth(int newMonth)
    {
        month = newMonth;
    }
    // sets day
    public void setDay(int newDay)
    {
        day = newDay;
    }

    // Valid Date Checker; @param year, month, day - returns true/false
    public boolean isValid()
    {
        return isValid(year, month, day);
    }
    public boolean isValid(Date date)
    {
        return isValid(date.year, date.month, date.day);
    }
   // At Least 30 Day Checker; @param month - returns true/false
   private boolean is30DayMonth(int month)
   {
        if (month == APR || month == JUN
                || month == SEP || month == NOV)
            return true;
        else
            return false;
    }
    // Converts to American view of inputed date.
    public String toString()
    {
        return new String(month + "/" + day + "/" + year);
    }
     
    public boolean isValid(int year, int month, int day)
    {
        boolean valid = true;
        if (day < 1 || day > 31)
            valid = false;
        else if (month < JAN || month > DEC)
            valid = false;
        // Leap Year Test; Extra-Credit
        else if (month == FEB && day > 28)
            valid = false;
        else if (day == 31 && is30DayMonth(month))
            valid = false;
        return valid;
    }
}// end class Date