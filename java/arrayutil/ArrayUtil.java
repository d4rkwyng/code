/**
 * CIS12  Asg6
 * ArrayUtil.java
 * Purpose: Sorts user's inputed number into numerical order and
 *          displays results.
 * @author Derek Wood
 * @version 1.0 10/23/02
 *          1.1 10/29/02
 */

import javax.swing.*;
import myutils.Algorithms;

public class ArrayUtil {
   /**
    * The main program for the ArrayUtil class
    *
    * @param args -- not used
    */
    public static void main(String[] args) {
    // Instance variables
    int i;
    int numItem = -1;
    boolean checkanswer = true;
    String sortanswer = "";
    String answer = "";
    String outputline = "";
    String outputline2 = "";
    String SnumItem = "";
   	String BorS = "";

       /**
        * Request EndUser to indicate
        *  Bubble or Selection Sort
        */
        while (checkanswer == true) {
        	BorS = JOptionPane.showInputDialog(
            	"Welcome! What would you like to use?\n"
            	+ "Please enter: <b> for BubbleSort\n"
            	+ "Or enter: <s> for the SelectionSort");
        	// Selection indicated
        	if ((BorS.equals("b")) || (BorS.equals("B"))) {
            	sortanswer = "Bubble";
            	checkanswer = false;
			}
        	else if ((BorS.equals("s")) || (BorS.equals("S"))) {
            	sortanswer = "Selection";
            	checkanswer = false;
			}
       		else { // error message
            	JOptionPane.showMessageDialog(null,
               		"Your input: <" + BorS + "> is an invalid entry.\n"
                	+ "Please try again!");
	 		}
	 	}// end of while

        checkanswer = true;
        while (checkanswer == true) {
		   /**
		    * Sets size of array on EndUser's input
		    *  EndUser's input must be an integer to work.
		    */
        	SnumItem = JOptionPane.showInputDialog(
            	"Welcome to the " + sortanswer + "Sorter\n" +
            	"How many integers would you like me to sort?");

        	// Verifies EndUser's input (must be a postive integer)
        	if (SnumItem.equals(""))
        		numItem = -1;
        	else
        		numItem = Integer.parseInt(SnumItem);
        	if (numItem <= 0) { // error message
            	JOptionPane.showMessageDialog(null,
                	"Your input: <" + SnumItem + "> is an invalid entry.\n"
                	+ "Please try again!");
            }
            else {
            	checkanswer = false;
            }
		}// end of while

        // Instance Array Variable
		int[] rXray = Algorithms.createArray(numItem);
        outputline = Algorithms.toString(rXray); // Save unsorted Array

       /**
        * Determines sort method and sorts
        *  Refer to Algorithms.java for code.
        */
        if (sortanswer.equals("Bubble"))
            Algorithms.bubbleSort(rXray);
        else
            Algorithms.selectionSort(rXray);

        // Creates final output
		outputline2 = Algorithms.toString(rXray);
        JOptionPane.showMessageDialog(null, sortanswer +
            "Sorter Algorithm\n" +
            "The unsorted numbers are:\n" + outputline +
            "\n\nThe sorted numbers are:\n" + outputline2);
        System.exit(0);// exits program
    }// end method main
}// end of class ArrayUtil