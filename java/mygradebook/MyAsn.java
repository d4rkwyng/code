package MyGradeBook;

/**
 * CIS20  Asn06
 * MyAsn.java
 * Purpose: Calculates the Assignment section for MyGradebook
 *
 * @author Derek Wood
 * @version 1.0
 */
public class MyAsn extends MyScores {
    private double value = 0;
    
    /**
     * Call superclass constructor passing parameters
     *
     * @param areaName The name of the MyScores object
     * @param areaWeight The score data
     * @param data The score data
     */
    public MyAsn(String areaName, double areaWeight, int[][] data) {
        super(areaName);
        loadScores(data);
        calcPercentage(areaWeight);
    }

    /**
     * Calculate totals from raw data
     *
     * @param -- not used
     * @return super.getPercent() The calculated percentages from the raw data
     */
    public double calcPercentage() {
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