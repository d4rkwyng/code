/**
 * CIS12  Asg7
 * Gradebook.java
 * Purpose: Determines overall percentage in class from four categories.
 * @author Derek Wood
 * @version 1.1 11.13.02
 * @updates: <comments inputed>
 *
 * created on: 11.10.02
 */

import java.text.*; //For DecimalFormat//

public class Gradebook {
    // decimalformat (percent.format) -- From GradeSum.class//
	DecimalFormat percent = new DecimalFormat("00.00%");

    private static final double powWeight = .15, midWeight = .20,
    	                        asgWeight = .40, fnlWeight = .25;
    private static MyScores powScores, midScores, asgScores, fnlScores;
    double finalPercentage;
    char letterGrade;

    //Sample data -- replace with your own data//
    //Data on left is possible -- on right is actual//
    int powData[][] = {{10,10,10,10,0,0}, {6,10,10,8,0,0}};
    int midData[][] = {{38,34}, {28,17}};
    int asgData[][] = {{8,14,12,12,16,16,16,0,0}, {4,14,12,14,15,14,17,0,0}};
    int fnlData[][] = {{0}, {0}};

   /**
    * The main program for GradeBook class
    *
    * @param args -- not used
	*/
	public static void main(String[] args) {
		Gradebook cis12 = new Gradebook();
		System.out.println("Testing for null values:");
        cis12.showValues(); //To test for null values -- can be removed//
        cis12.loadScores();
        cis12.calcPercentage();
        System.out.println("Calculations:");
        cis12.showValues();
        cis12.calcLetterGrade();
        cis12.displayGrades();

        //Extra Credit -- To get an A in class//
        cis12.gradeA();
        cis12.calcLetterGrade();
        cis12.displayGrades();
    } //end method main//

   /**
    * Collection of default variables and contructors.
    *
    * @param -- not used
	*/
    public Gradebook() {
        finalPercentage = 0.0;
        letterGrade = 'z';
        //Constructor for MyScores called 4 times//
        powScores = new MyScores();
        midScores = new MyScores();
        asgScores = new MyScores();
        fnlScores = new MyScores();
    }

   /**
    * Passes weight and data to be calculated.
    *
    * @param -- not used
	*/
    void loadScores() {
		powScores.MyScores(powWeight);
		midScores.MyScores(midWeight);
		asgScores.MyScores(asgWeight);
		fnlScores.MyScores(fnlWeight);
        powScores.loadScores(powData);
		midScores.loadScores(midData);
		asgScores.loadScores(asgData);
		fnlScores.loadScores(fnlData);
    }

   /**
    * Calculates overall grade from the four categories.
    *
    * @param -- not used
	*/
    void calcPercentage() {
        double pow = powScores.getPercentage();
        double mid = midScores.getPercentage();
        double asg = asgScores.getPercentage();
        double fnl = fnlScores.getPercentage();
        //Compute the overall grade percentage.//
        //Replace computation with the 0.//
        finalPercentage = (pow + mid + asg + fnl) * 100;
    }

   /**
    * Determines grade from finalpercentage
    *
    * @param -- not used
	*/
    void calcLetterGrade() {
        //Determine letter from finalPercentage//
        //Code taken from GradeSum class file//
		if (finalPercentage >= 90) letterGrade = 'A';
		else if (finalPercentage >= 80) letterGrade = 'B';
		else if (finalPercentage >= 70) letterGrade = 'C';
		else if (finalPercentage >= 60) letterGrade = 'D';
        else letterGrade = 'F';
    }

   /**
    * Displays what calculations are being done for EndUser to view.
    *   (refer to MyScores class (showValues method))
    * @param -- not used
	*/
    void showValues() {
        System.out.print("POW part:     ");
        powScores.showValues();
        System.out.print("Midterm part: ");
        midScores.showValues();
        System.out.print("Asg part:     ");
        asgScores.showValues();
        System.out.print("Final part:   ");
        fnlScores.showValues();
        System.out.println();
    }

   /**
    * Displays the final calculated output.
    *
    * @param -- not used
	*/
    void displayGrades() {
        //Feel free to improve the formatting of output//
        System.out.println(
				"\nMy final percentage is: " + percent.format(finalPercentage / 100) +
        		"\nMy final letter grade is: " + letterGrade);
	}

   /**
    * Extra-Credit
    *
    * @param -- not used
	*/
	void gradeA() {
        double pow = powScores.getPercentage();
        double mid = midScores.getPercentage();
        double asg = asgScores.getPercentage();
		double fnl = .27315;
        System.out.println("\nExtra Credit -- to get an A:" +
        					"\n110/100 or .27315 out of .25" +
        					"\n\nCalculations:");
        System.out.println(percent.format(pow) + " + " + percent.format(mid) +
        		   " + " + percent.format(asg) + " + " + percent.format(fnl));
        //Compute the overall grade//
		finalPercentage = (pow + mid + asg + fnl) * 100;
   }
} //End GradeBook class//


//MyScores class file//
class MyScores {
	DecimalFormat percent = new DecimalFormat("00.00%"); //To make compiler happy//

    private double actual, possible, weight, value;

   /**
    * @param categoryWeight -- catches TYPEweight and converts to variable weight.
    *                          (Where TYPE is: pow, mid, asg, and fnl)
	*/
    public void MyScores(double categoryWeight) {
		actual = 0.0;
        possible = 0.0;
        value = 0.0;
        weight = categoryWeight;
    }

   /**
    * Loads the scores and sets to actual & possible variables.
    *
    * @param scores -- 2D array to be loaded.
	*/
    public void loadScores(int[][] scores) {
        //Calculate totals from raw data//
        int i, j;
		for (i = 0; i < scores.length - 1; i++) {
				for (j = 0; j < scores[i].length; j++) {
					actual += scores[i + 1][j];
					possible += scores[i][j];
				}
		}
    }

   /**
	* Calculates percentage of input.
	*
	* @param -- not used.
	* @return -- calculated input.
	*/
    public double getPercentage() {
        value = 0.0;
        if (possible > 0) {
            value = (actual / possible);
			if (value > possible) value = possible;
            value *= weight;
		}
        return value;
    }

   /**
    * Displays what calculations are being done for EndUser to view.
    *
    * @param -- not used
	*/
    public void showValues() {
		//Feel free to improve the formatting of output//
		System.out.print(
						"(" + actual + " / " + possible + ")" +
						" * " + weight +
       					" = " + percent.format(value) + "\n");
    }
} //End MyScores Class//
//Thanks Ed.//