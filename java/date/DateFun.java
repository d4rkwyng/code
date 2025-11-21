/**
 * CIS12  Asg5
 * DateFun.java
 * Purpose: Just something stupid.
 * @author Derek Wood
 * @version 1.0 10/20/02
 */

public class DateFun
{
    /**
     * The main program for the DateTest class
     *
     * @param args -- not used
     */
     public static void main (String args[])
     {
        // Just a test
        Date today = new Date(1234,56,78);
        Date empty = new Date();
        System.out.println("Test date: 1234,56,78");
        System.out.println("This is a stupid test, "
            + today.getMonth() + "/" + today.getDay()
            + "/" + today.getYear());
        System.out.println("Funny how that works?");
    }// end method main
}// end class DateFun