/**
 * CIS12  Asg6
 * Algorithms.java
 * Purpose: Bubble Sort and Selection Sort Algorithms File.
 * @author Derek Wood
 * @version 1.0 10/29/02
 */

package myutils;
import javax.swing.*;

public class Algorithms {
	public static int[] createArray(int numItem) {
	int[] Xray = new int [numItem];
	int i;
	boolean checkanswer;
	String answer = "";
    String outputline = "";
    String outputline2 = "";
	checkanswer = true;
        while (checkanswer == true) {
			// Options for Random or EndUser input
        	answer = JOptionPane.showInputDialog(
           		" Options:\n" +
            	"Please enter: <e> to enter the integers yourself.\n"
            	+ "Or enter: <r> to generate " + numItem +
            	" out of 1000 random numbers.");

        	// Randomize (If EndUser input is 'r' or 'R')
        	if ((answer.equals("r")) || (answer.equals("R"))) {
            	for (i = 0; i < Xray.length; i++) {
                 	/**
                     * Randomizes any number between 1 - 1000
                     * The int range is -2147483648 to 2147483647
                     */
                     int r = (int)(Math.random() * 1000);
                     Xray[i] = r;
                }
             	checkanswer = false;
        	}
        	// Continue (If EndUser's input is 'e' or 'E')
        	else if ((answer.equals("e")) || (answer.equals("E"))) {
            	for (i = 0; i < Xray.length; i++) {
                	Xray[i] = Integer.parseInt(JOptionPane.showInputDialog(
                    	"Enter integer #" + (i+1) + " of "
                    	+ numItem + ":"));
            	outputline = outputline + " " + Xray[i];
            	checkanswer = false;
            	}
        	}
        	else { // error message
            	JOptionPane.showMessageDialog(null,
                	"Your input: <" + answer + "> is an invalid entry.\n"
                	+ "Please try again!");
	 		}
 		}// end of while
 		return Xray;
	}

	public static String toString(int[] array) {
	int i;
	String outputline = "";
        for (i = 0; i < array.length; i++)
            outputline = outputline + " " + array[i];
        return outputline;
	}

   	// Bubble Sorter Algorithm
	public static void bubbleSort(int[] a) {
	 	int index;
	 	boolean checksort = true;
	 	while (checksort == true) {
			checksort = false;
			for (index = 0; index < a.length - 1; index++) {
				if(a[index] > a[index + 1]) {
					swap(a, index, index + 1);
					checksort = true;
				}
			}
		}
	}

	// Selection Sorter Algorithm
	public static void selectionSort(int[] a) {
	 	int index, indexOfMin;
		for (index = 0; index < a.length - 1; index++) {
			indexOfMin = findMin(a, index, a.length - 1);
			swap(a, index, indexOfMin);
		}
	}
	// Selection Sorter Find Minimum
	private static int findMin(int[] a, int start, int end) {
		int indexOfMin = start;
		for (int i = start + 1; i <= end; i++) {
			if (a[i] < a[indexOfMin]) {
				indexOfMin = i;
			}
		}
		return indexOfMin;
	}

	// Swap two Array variables
	private static void swap(int[] a, int first, int second) {
		int temp = a[first];
		a[first] = a[second];
		a[second] = temp;
	}
}// end class Algorithms