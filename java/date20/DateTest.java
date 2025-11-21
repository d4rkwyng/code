/**
 * CIS-20  Asn 9
 * DateTest.java
 * Purpose: Tests the Date class
 *
 * @author Ed Parrish
 * @version 1.0 1/30/03
 */
public class DateTest {
    private static int daysPerMonth[] =
        {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    /**
     * The main program for the DateTest class
     *
     * @param args -- not used
     */
    public static void main (String[] args) {
        testDate();
        testDate2();
        testSetDate();
        testNextDay();
        testToString();
        System.out.println("*** All automatic tests passed ***");
    }

    /**
     * Convenience method to test for assertions.
     *
     * @param condition The test condition that must be true to pass.
     * @param message The reason for the failure.
     */
    public static void assertTrue(boolean condition, String message) {
        if (!condition) {
            throw new RuntimeException(message);
        }
    }

    /**
     * Test method: public Date() and get methods
     */
    public static void testDate() {
        System.out.println("Testing Date() and get methods");
        Date d = new Date();
        int m = d.getMonth();
        assertTrue(m > 0, "Month < 1: " + m);
        assertTrue(m < 13, "Month > 12: " + m);
        int day = d.getMonth();
        assertTrue(day > 0, "Day < 1: " + day);
        assertTrue(day < daysPerMonth[m], // does not account for leap year
            "Day > " + daysPerMonth[m] + ": " + day);
        d.getYear();
    }

    /**
     * Test method: public Date(int, int, int)
     */
    public static void testDate2() {
        System.out.println("Testing Date(int, int, int)");
        Date date;
        try {
            date = new Date(2003, 12, 31); // End of year
            date = new Date(2003, 2, 28);  // Date not a leap year
            date = new Date(2004, 2, 29);  // Date is a leap year
        } catch(MonthException e) {
            assertTrue(false, e.getMessage());
        } catch(DayException e) {
            assertTrue(false, e.getMessage());
        }

        try {
            date = new Date(2003, 13, 30); // Invalid month
        } catch(MonthException e) {
            // Do nothing -- this should happen
        } catch(DayException e) {
            assertTrue(false, e.getMessage());
        }

        try {
            date = new Date(2003, 1, 0); // Invalid day
        } catch(MonthException e) {
            assertTrue(false, e.getMessage());
        } catch(DayException e) {
            // Do nothing -- this should happen
        }
   }

    /**
     * Test method: public void setDate(int, int, int)
     */
    public static void testSetDate() {
        System.out.println("Testing setDate(int, int, int)");
        Date date = new Date();
        try {
            date.setDate(2003, 12, 31); // End of year
            date.setDate(2003, 2, 28);  // Date not a leap year
            date.setDate(2004, 2, 29);  // Date is a leap year
        } catch(MonthException e) {
            assertTrue(false, e.getMessage());
        } catch(DayException e) {
            assertTrue(false, e.getMessage());
        }

        try {
            date.setDate(2003, 13, 30); // Invalid month
        } catch(MonthException e) {
            // Do nothing -- this should happen
        } catch(DayException e) {
            assertTrue(false, e.getMessage());
        }

        try {
            date.setDate(2003, 1, 0); // Invalid day
        } catch(MonthException e) {
            assertTrue(false, e.getMessage());
        } catch(DayException e) {
            // Do nothing -- this should happen
        }
   }


    /**
     * Test method: public void nextDay()
     */
    public static void testNextDay() {
        System.out.println("Testing nextDay()");
        Date d;
        try {
            d = new Date(2003, 12, 31); // End of year
            d.nextDay();
            assertTrue(d.getDay() == 1,
                "Day did not roll over: " + d.getDay());
            assertTrue(d.getMonth() == 1,
                "Month did not roll over: " + d.getMonth());
            assertTrue(d.getYear() == 2004,
                "Year did not roll over: " + d.getYear());

            d = new Date(2003, 2, 28);  // Date not a leap year
            d.nextDay();
            assertTrue(d.getDay() == 1,
                "Day did not roll over: " + d.getDay());
            assertTrue(d.getMonth() == 3,
                "Month did not roll over: " + d.getMonth());
            assertTrue(d.getYear() == 2003,
                "Year changed unexpectedly: " + d.getYear());

            d = new Date(2004, 2, 28);  // Date is a leap year
            d.nextDay();
            assertTrue(d.getDay() == 29,
                "Day changed unexpectedly: " + d.getDay());
            assertTrue(d.getMonth() == 2,
                "Month changed unexpectedly: " + d.getMonth());
            assertTrue(d.getYear() == 2004,
                "Year changed unexpectedly: " + d.getYear());
        } catch(MonthException e) {
            assertTrue(false, e.getMessage());
        } catch(DayException e) {
            assertTrue(false, e.getMessage());
        }
    }


     /**
     * Test method: public String toString()
     */
    public static void testToString() {
        System.out.println("Testing toString()");
        Date d;
        try {
            d = new Date(2003, 12, 25); // Meryy Christmas!
            assertTrue(d.toString().equals("12/25/2003"),
                "\nError in toString: " + d.toString());
        } catch(MonthException e) {
            assertTrue(false, e.getMessage());
        } catch(DayException e) {
            assertTrue(false, e.getMessage());
        }
    }
}
