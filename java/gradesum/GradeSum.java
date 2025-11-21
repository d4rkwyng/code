/**
 * CIS12  Asg4
 * GradeSum.java
 * Purpose: Calculates total/average/range/percentage of user's inputed exam
 * 			grades.
 *
 * @author Derek Wood
 * @version 1.1 10/2/02
 *          1.0 9/30/02
 */

    import java.text.*;

public class GradeSum
{
    /**
     * The main program for the GradeSum class
     *
     * @param args -- not used
     */
     public static void main(String[] args)
     {
       /**
        * Creates an easy-to-use program which allows the user to enter any
        * amount of numbers and therefore, receive details upon their input.
        */
       // decimalformat (formatter.percent)
       DecimalFormat percent = new DecimalFormat("0.00%");
       // collection of instance variables
       int count; // total number of enteries
       double sum; // overall total of all entries
       double lowvalue, highvalue; // range variables
       double Acount, Bcount, Ccount, Dcount, Fcount; // grade variables
       double next;
       char answer;

        do
        {
            System.out.println();
            System.out.println("~Grade Summarizer~");
            System.out.println(
                "Please enter the grades to be summarized,"
                + " one grade per line.");
            System.out.println(
                "When finished, enter a '-1' to signal the"
                + " end of the grades.");
            System.out.println();

            // initialise instance variables
            sum = 0;
            count = 0;
            Acount = 0;
            Bcount = 0;
            Ccount = 0;
            Dcount = 0;
            Fcount = 0;
            next = SavitchIn.readLineDouble();
            lowvalue = next;
            highvalue = next;

            while (next >= 0) // properties for calculations
            {
                sum = sum + next; // calculation of total inputed values
                count++;
                // range properties
                if (next > highvalue)
                    highvalue = next;
                if (next < lowvalue)
                    lowvalue = next;
                // grade variables
                if (next >= 90)
                    Acount++;
                else if (next >= 80)
                    Bcount++;
                else if (next >= 70)
                    Ccount++;
                else if (next >= 60)
                    Dcount++;
                else
                    Fcount++;
                next = SavitchIn.readLineDouble();
            }

            if (count > 0) // outputs results from user's inputed values
            {
                /**
                 * Gets users input and checks to see if positive; program
                 * will not allow negative inputed values.
                 */
                 System.out.println("Total number of grades: "
                    + count);
                 // outputs amount of each value
                 System.out.println("Number of A's: " + Acount);
                 System.out.println("Number of B's: " + Bcount);
                 System.out.println("Number of C's: " + Ccount);
                 System.out.println("Number of D's: " + Dcount);
                 System.out.println("Number of F's: " + Fcount);
                 // outputs overall percentage for each value
                 if (Acount != 0)
                    System.out.println("Percent of A's: "
                        + percent.format(Acount/count));
                 else
                    System.out.println("Percent of A's: 00.00%");
                 if (Bcount != 0)
                    System.out.println("Percent of B's: "
                        + percent.format(Bcount/count));
                 else
                    System.out.println("Percent of B's: 00.00%");
                 if (Ccount != 0)
                    System.out.println("Percent of C's: "
                        + percent.format(Ccount/count));
                 else
                    System.out.println("Percent of C's: 00.00%");
                 if (Dcount != 0)
                    System.out.println("Percent of D's: "
                        + percent.format(Dcount/count));
                 else
                    System.out.println("Percent of D's: 00.00%");
                 if (Fcount != 0)
                    System.out.println("Percent of F's: "
                        + percent.format(Fcount/count));
                 else
                    System.out.println("Percent of F's: 00.00%");
                 // outputs the range of lowest to highest inputed values
                 System.out.println("Range of scores: "
                    + lowvalue + " - " + highvalue);
                 // outputs the average of all inputed values
                 System.out.println("Average Score: "
                    + percent.format(sum/count/100));
            }

            else // outputs error message
            {
                /**
                 * If inputed value is negative, the program will display
                 * an error message and allow the user to try again.
                 */
                 System.out.println();
                 System.out.println("ERROR: Negative input");
                 System.out.println("Try Again!");
                 System.out.println();
            }
            // loop action
            System.out.println();
            System.out.println("Want to average another exam?");
            System.out.println("Enter 'y' for yes or 'n' for no.");
            answer = SavitchIn.readLineNonwhiteChar();
         }

        while ((answer == 'y') || (answer == 'Y'));

    }//end method main
}//end class GradeSum