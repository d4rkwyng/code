/**
 * CIS12  Asg5
 * DateTest.java
 * Purpose:  Tests the methods and constructors of the Date class.
 *
 * @author Derek Wood
 * @version 1.0 10/16/02
 */

public class DateTest
{
    /**
     * The main program for the DateTest class
     *
     * @param args -- not used
     */
     public static void main (String args[])
     {
        // Site Example
        Date today = new Date(2002,11,12);
        Date empty = new Date();
        System.out.println("Today is: "
            + today.getMonth() + "/" + today.getDay()
            + "/" + today.getYear());
        // Tomorrow Setting
        today.setDay(13);
        System.out.println("Tommorrow is going to be: "
            + today.toString());

        // Incorrect DateTest
        System.out.println();
        System.out.println("Example of an Incorrect Date");
        System.out.println("Incorrect date: " + empty.toString());
        System.out.println("Is this date valid? " + empty.isValid());
        System.out.println();

        // Correct DateTest - My Birthday Test
        empty.setMonth(9);
        empty.setDay(13);
        empty.setYear(83);
        System.out.println("Example of a Correct Date");
        System.out.println("My Birthday is: " + empty.toString());
        System.out.println("My Birthday valid? " + today.isValid());
        System.out.println("Well of course it is!!");
    }// end method main
}// end class DateTest