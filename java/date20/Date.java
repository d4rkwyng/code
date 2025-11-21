import java.io.*;
import javax.swing.*;

/**
 * CIS20  Asn 9
 * Date.java
 * Purpose: Analyzes the date values and checks for accuracy.  Can also
 *          increment the next day value.
 *
 * @author Derek Wood
 * @version 1.0 4/30/03
 */
public class Date {
    // Intialize Month Variables
    public final static int
        JAN = 1, FEB = 2, MAR = 3,
        APR = 4, MAY = 5, JUN = 6,
        JUL = 7, AUG = 8, SEP = 9,
        OCT = 10, NOV = 11, DEC = 12;
    private int year;
    private int month;
    private int day;

    /**
     * Default constructor that sets this Date to a valid date
     */
    public Date() {
		year = 2003;
		month = 5;
		day = 1;
	}

    /**
     * Overloaded constructor to set this Date to the specified values
     *
     * @param newYear, newMonth, newDay - values received to be set
     */
    public Date(int newYear, int newMonth, int newDay)
    		throws DayException, MonthException {
		year = newYear;
		month = newMonth;
		day = newDay;
    }

    /**
     * Sets this Date to the specified values
     *
     * @param newYear, newMonth, newDay - values received to be checked/set
     */
    public void setDate(int newYear, int newMonth, int newDay)
    		throws DayException, MonthException {
        try {
            if (newDay < 1 || newDay > 31) {
            	throw new DayException("Invalid day value: " + newDay);
            } else if (newMonth < JAN || newMonth > DEC) {
            	throw new MonthException("Invalid month value: " + newDay);
            } else if (newDay == 31 && is30DayMonth(newMonth)) {
            	throw new MonthException("February cannot contain day value: " + newDay);
            } else if ((month == FEB && day == 29) && !((year % 400 == 0 ||
                   (year % 4 == 0 && year % 100 != 0)))) {
                throw new MonthException("February cannot contain day value: " + newDay);
            }
        } catch(DayException e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        } catch(MonthException e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        } catch(Exception e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        } finally {
            year = newYear;
            month = newMonth;
            day = newDay;
        }
    }

    /**
     * Sends the year, month, day to be checked
     */
    public boolean isValid() {
        return isValid(year, month, day);
    }

    /**
     * Sends the year, month, day to be checked
     */
    public boolean isValid(Date date) {
        return isValid(date.year, date.month, date.day);
    }

    /**
     * Checks the date and returns a boolean true/false
     *
     * @param year, month, day - Values to be checked
     * @return valid - true/false
     */
    public boolean isValid(int year, int month, int day) {
        boolean valid = true;
        if (day < 1 || day > 31)
            valid = false;
        else if (month < JAN || month > DEC)
            valid = false;
        else if (day == 31 && is30DayMonth(month))
            valid = false;
        else if ((month == FEB && day == 29) && !((year % 400 == 0 ||
                   (year % 4 == 0 && year % 100 != 0))))
            valid = false;
        return valid;
    }

    /**
     * Returns the year
     */
    public int getYear() {
        return year;
    }

    /**
     * Returns the month
     */
    public int getMonth() {
        return month;
    }

    /**
     * Returns the day
     */
    public int getDay() {
        return day;
    }

    /**
     * Sets the year
     */
    public void setYear(int newYear) {
        year = newYear;
    }

    /**
     * Sets the month
     */
    public void setMonth(int newMonth) {
        month = newMonth;
    }

    /**
     * Sets the day
     */
    public void setDay(int newDay) {
        day = newDay;
    }

    /**
     * Determines whether month sent is 30 days
     *
     * @param month - month to be checked
     * @return boolean true/false
     */
    public boolean is30DayMonth(int month) {
        if (month == APR || month == JUN
                || month == SEP || month == NOV)
            return true;
        else
            return false;
    }

    /**
     * Returns a String representation for this Date.
     * For example, if the year were 2002, the month 11, and the day 12
     * you should return the string 11/12/2002.
     */
    public String toString() {
        return new String(getMonth() + "/" + getDay() + "/" + getYear());
    }

    /**
     *  Increments the day, adjusting the month and year if necessary.
     *  Returns the current Date object adjusted to the new settings.
     */
    //edit
    public void nextDay() {
        if (day >= 28) {
            if ((day == 31) && (month == DEC)) {
                day = 1;
                month = 1;
                year++;
            } else if (((day == 30) && is30DayMonth(month)) || (day == 31)) {
                day = 1;
                month++;
            } else if (month == FEB) {
               if ((day == 28) && (year % 400 == 0 ||
                   (year % 4 == 0 && year % 100 != 0))) {
                    day++;
               } else if (day == 29) {
                    day = 1;
                    month++;
                } else {
                    day = 1;
                    month++;
                }
            } else
                day++;
        } else
            day++;
    }
}

/**
 * CIS20  Asn 9
 * Date.java
 * Purpose: Custom Exception for invalid days
 *
 * @author Derek Wood
 * @version 1.0 4/30/03
 */
class DayException extends Exception {
    /**
     *  Default Constructor for the DayException
     */
    public DayException() {
        super("Day Error");
    }

    /**
     *  Sets the message to the caught exception
     */
    public DayException(String message) {
        super(message);
    }
}

/**
 * CIS20  Asn 9
 * Date.java
 * Purpose: Custom Exception for invalid monthes
 *
 * @author Derek Wood
 * @version 1.0 4/30/03
 */
class MonthException extends Exception {
    /**
     *  Default Constructor for the MonthException
     */
    public MonthException() {
        super("Month Error");
    }

    /**
     *  Sets the message to the caught exception
     */
    public MonthException(String message) {
        super(message);
    }
}