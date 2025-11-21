/**
 * CIS20  Asn2
 * DecimalPalindrome.java
 * Purpose: Reads input from End User and determines whether or not it is a Decimal Palindrome.
 *
 * @author Derek Wood
 * @version 1.0 2/25/03
 */

import java.io.*;
import java.text.*;

public class DecimalPalindrome {
    /**
     * The main program for the DecimalPalindrome class.  See: Program Purpose.
     *
     * @param args -- Allows input arguments.
     */
     public static void main(String[] args) {
       double input;
       char answer;
       int lHalf, rHalf;
       int rNum[] = new int [5];

       double drHalf;
       	do {
            System.out.println("\nEnter a 10-digit number\n" +
                			   "with a decimal point in the middle: ");
            input = Console.readDouble();
			lHalf = (int) input;
			rHalf = (int) Math.floor(((input - lHalf) * 100000) + 0.5);

			// Separate into Expanded notation
			rNum[4] = (int) (rHalf / 10000);
			rNum[3] = (int) ((rHalf - (rNum[4] * 10000)) / 1000);
			rNum[2] = (int) ((rHalf - ((rNum[4] * 10000) + (rNum[3] * 1000))) / 100);
			rNum[1] = (int) ((rHalf - ((rNum[4] * 10000) + (rNum[3] * 1000) + (rNum[2] * 100))) / 10);
			rNum[0] = (int) (rHalf - ((rNum[4] * 10000) + (rNum[3] * 1000) + (rNum[2] * 100) + (rNum[1] * 10)));

			// Reverses it
			rHalf = ((rNum[0] * 10000) + (rNum[1] * 1000) + (rNum[2] * 100) + (rNum[3] * 10) + rNum[4]);

			// Compares the left side to the reversed right side
            if (rHalf == lHalf)
            	System.out.println(input + " is a decimal palindrome!!!\n");
            else
            	System.out.println(input + " is not a decimal palindrome!!!\n");

            System.out.println("Enter 'y' to try again or any key(s) to end.");
			answer = readChar();
		}
		// If the EndUser's input is 'y' or 'Y' it'll loop, otherwise exit.
		while ((answer == 'y') || (answer == 'Y'));
    }

    /**
     * Checks to see if the EndUser's input it a character and catches null point exceptions.
     *
     * @param args -- not used
     */
     public static char readChar() {
     	boolean fin = false;
     	String inStr = null;
        char wSpace = ' ';
        while (! fin) {
            inStr = Console.readLine();
            // Catches null from possible batch file testing.
            if (inStr == null)
            	return 'n';
            inStr = inStr.trim();
            if (inStr.length() == 0) {
            	System.out.println("Your input is incorrect.\n" +
                				   "Try Again!");
            }
            else {
                wSpace = (inStr.charAt(0));
                fin = true;
            }
        }
        return wSpace;
    }
}