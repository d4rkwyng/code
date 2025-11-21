/**
 * CIS20  Asn3
 * InterestCalculator.java
 *
 * Purpose: Gets value from intial, rate, and term in years.
 *
 * @author Derek Wood
 * @version 1.0 3/5/03
 */

import java.text.*; //Decimal Formatter

public class InterestCalculator {
	/**
	 * The main program for the InterestCalculator class.
	 *
	 * @param args - Catches the InterestCalcTest value (null)
     */
    public static void main(String[] args) {
		if (args == null) return;

		//Process Variables
        double inInvest, anPercent, termYr;
        double finVal;
        char answer;

		DecimalFormat percent = new DecimalFormat("$#.00");

        //User interface
       	do {
			System.out.println("This program calculates the final value of\n" +
				"an investment using the continuous interest method.\n");
        	System.out.print("Initial investment: ");
        	inInvest = Console.readDouble();
        	System.out.print("Annual percentage rate: ");
        	anPercent = Console.readDouble();
        	System.out.print("Term in years: ");
        	termYr = Console.readDouble();

			//Calls the method finalValue with the 3 values

			finVal = finalValue(inInvest, anPercent, termYr);
        	System.out.println("\nFinal value: " + percent.format(finVal));
        	finVal = recurValue(inInvest, anPercent, termYr);
        	System.out.println("Recursive Final value: " + percent.format(finVal));

			//"Where's the 'any' key?" - Homer Simpson
        	System.out.println("\nEnter 'y' to try again or press any key to terminate.");
			answer = readChar();
			System.out.println();
			}
		//If the EndUser's input is 'y' or 'Y' it'll loop, otherwise exit.
		while ((answer == 'y') || (answer == 'Y'));
	}

	/**
	 * Read an char on a single line from the shell console.
     *
     * @return A char input by the user.
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

    /**
     * Calculations for e (factor/factorial)
     *
     * @param x - Catches the (rate * term) value,
     * @return The value of e.
	 */
    public static double exp(double x) {
		//Process Variables
		double eReturn = 1, factor = 1, factorial = 1;
		int counter = 1;
		double ans = 1;

		while (counter > 0) {
			for (int j = 1; j <= counter; j++) factor *= x;
			for (int k = counter; k > 0; k--) factorial *= k;

			ans = (factor / factorial);

			//Resets variables
			factor = 1;
			factorial = 1;

			counter++;
			eReturn += ans;

			//Calculating to fifth decimal place to avoid infinite loop.
			if (ans < .00001) counter = 0;
		}
		return eReturn;
	}

    /**
     * Calculations for finVal and returns
     *
     * @param pv - Intial Interest, rate - Annual Percentage, term - Term in Years
     * @return The final calulated value.
     */
	public static double finalValue(double pv, double rate, double term) {
		return (exp(rate * term)) * pv;
	}

	/**
     * Extra-Credit Recursion
     *
     * @param pv - Intial Interest, rate - Annual Percentage, term - Term in Years
     * @return The final calulated value.
	 */
	public static double recurValue(double pv, double rate, double term) {
		return (rxp(rate * term)) * pv;
	}

    /**
     * Recur. Calculations for e (factor/factorial)
     *
     * @param x - (rate * term)
     * @return The value of e.
	 */
    public static double rxp(double x) {
		//Process Variables
		double eReturn = 1;
		int counter = 1;
		double ans = 1;

		while (ans > 0.00001) {
			ans = ((CalcFactor(x, counter)) / (CalcFactorial(counter++)));
			eReturn += ans;
		}
		return eReturn;
	}

    /**
     * Calculates the numerator (Factor).
     *
     * @param n - (rate * term), c - Exp. power
     * @return The numerator (Factor)
	 */
	public static double CalcFactor(double n, int c) {
		if (c == 0) return 1;
		else return (n * CalcFactor(n, (c - 1)));
	}

    /**
     * Calculates the denominator (Factorial)
     *
     * @param y - Counter
     * @return The denominator (Factorial)
	 */
	public static double CalcFactorial(int y) {
		double n = (double) y;
		if (n == 0) return (n + 1);
		else return (n * CalcFactorial(y - 1));
	}
}