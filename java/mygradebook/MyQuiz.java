package MyGradeBook;

/**
 * CIS20  Asn06
 * MyQuiz.java
 * Purpose: Calculates the Quiz section for MyGradebook
 *
 * @author Derek Wood
 * @version 1.0
 */
public class MyQuiz extends MyScores {
    private double value = 0;
    private int[][] altdata;
    
    /**
     * Call superclass constructor passing parameters
     *
     * @param areaName The name of the MyScores object
     * @param areaWeight The score data
     * @param data The score data
     */
    public MyQuiz(String areaName, double areaWeight, int[][] data) {
        super(areaName);
        extractLowScore(data);
        loadScores(altdata);
        calcPercentage(areaWeight);
    }

    /**
     * Extracts the lowest score from the data
     *
     * @param input The input to be searched
     */
    public void extractLowScore(int[][] input) {
        int minVal = 0;
        for (int i = 0; i <= input.length; i++) {
            if (input[1][i] < input[1][minVal])
                minVal = i;
        }
        input[0][minVal] = 0;
        input[1][minVal] = 0;
        altdata = input;
    }

    /**
     * Calculate totals from raw data
     *
     * @param -- not used
     * @return super.getPercent() The calculated percentages from the raw data
     */
    public double calcPercentage() {
        //implement calculation and return appropriate values
        return super.getPercent();
    }
    
    /**
     * Returns the name of the section
     *
     * @param -- not used
     * @return super.getName() The name of the section
     */
    public String getName() {
        return super.getName();
    }
}