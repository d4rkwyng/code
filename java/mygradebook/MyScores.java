package MyGradeBook;

/**
 * CIS20  Asn6
 * MyScores.java
 * Purpose:
 *
 * @author Derek Wood
 * @version 1.0
 */
public abstract class MyScores {
    private String name = "No name";
    private int[][] myData;
    private double actual, possible, calcPercent, value;

    /**
     * Default constructor initializes data with empty array
     *
     * @param -- not used
     */
    public MyScores() {
        myData = new int[0][0];
        possible = 0.0;
        calcPercent = 0.0;
        value = 0.0;
    }

    /**
     * Sets vale of name to the name of the section
     *
     * @param IntialName The name of the section
     */
    public MyScores(String IntialName) {
        name = IntialName;
    }

    /**
     * Abstract method to calculate scores overridden in subclasses
     *
     * @param weight The weight to calculate percentage with
     */
    public void calcPercentage(double weight) {
        if (possible > 0) calcPercent = (actual / possible);
        if (calcPercent > possible) calcPercent = possible;
        calcPercent *= weight;
    }
    
    /**
     * Returns the name of the section
     *
     * @param -- not used
     * @return name The name of the section
     */
    public String getName() {
        return name;
    }

    /**
     * Returns the Calculated percent
     *
     * @param -- not used
     * @return calcPercent The calculated value
     */
    public double getPercent() {
        return calcPercent;
    }
    
    /**
     * General purpose method to convert percentage to letter grades
     *
     * @param percentage The percentage to convert
     * @return toLetterGrade The letter grade
     */
    public static char toLetterGrade(double percentage) {
        char toLetterGrade;
        percentage = percentage * 100;
        //implement calculation and return appropriate values
        if (percentage >= 90) {
            toLetterGrade = 'A';
        } else if (percentage >= 80) {
            toLetterGrade = 'B';
        } else if (percentage >= 70) {
            toLetterGrade = 'C';
        } else if (percentage >= 60) {
            toLetterGrade = 'D';
        } else {
            toLetterGrade = 'F';
        }
        return toLetterGrade;
    }
   
    /**
     * Loads the scores into the array
     *
     * @param scores The score to be loaded
     */
    public void loadScores(int[][] scores) {
        //Calculate totals from raw data//
        myData = scores;
        int i, j;
            for (i = 0; i < myData.length - 1; i++) {
                for (j = 0; j < myData[i].length; j++) {
                    actual += myData[i + 1][j];
                    possible += myData[i][j];
                }
            }
    } 
}