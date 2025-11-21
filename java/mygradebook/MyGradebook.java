package MyGradeBook;
import java.text.*; //Decimal Format

/**
 * CIS20  Asn 6
 * MyGradebook.java
 * Purpose: Calculate and report on my grade
 *
 * @author Derek Wood
 * @version 1.0
 */
public class MyGradebook {
    public static final double asnWeight = .25;
    public static final double quizWeight = .25;
    public static final double midWeight = .20;
    public static final double fnlWeight = .30;
    public static final int SCORE_TYPES = 4;

    //Sample data -- do not change for this assignment
    //Replace with your own data to actually use it
    //Row 0: possible scores, Row 1: actual scores
    private int asnData[][] = {{10,20,20,20}, {10,20,21,22}};
    private int[][] quizData = {{10,10,10}, {10,9,8}};
    private int[][] midData = {{50}, {40}};
    private int[][] fnlData = {{0}, {0}};

    private MyScores scores[];

    /**
     * Contructor that shows scores
     *
     * @param -- not used
     */
    public MyGradebook() {
        scores = new MyScores[SCORE_TYPES];
        
        //instantiate each object and assign to scores array
        MyAsn ma = new MyAsn("Assignments", asnWeight, asnData);
        MyQuiz mq = new MyQuiz("Quizzes", quizWeight, quizData);
        MyMid mm = new MyMid("Midterm", midWeight, midData);
        MyFnl mf = new MyFnl("Final", fnlWeight, fnlData);
        
        scores[0] = ma;
        scores[1] = mq;
        scores[2] = mm;
        scores[3] = mf;
    }
    
    /**
     * Report score results
     *
     * @param -- not used
     */
    public void reportGrade() {
        double total = 0.0;
        double score = 0.0;
        String output = "";
        
        DecimalFormat percent = new DecimalFormat("00.00%");
        
        System.out.println("Weighted Percentages:");
        
        //accumulate scores and display weighted percentages for each area
        for (int i = 0; i < scores.length; i++) {
            score = scores[i].getPercent();
            total += score;
            output += scores[i].getName() + " : " + percent.format(score) + "\n";
        }
        System.out.println(output);
        
        System.out.println("Total to date: " + percent.format(total));
        System.out.println("Letter grade to date: "
            + MyScores.toLetterGrade(total));
        total = total / (1 - fnlWeight);
        System.out.println("Total excluding final: " + percent.format(total));
        System.out.println("Letter grade excluding final: "
            + MyScores.toLetterGrade(total));
    }

    /**
     * Create a MyGradebook object
     *
     * @param args -- not used
     */
    public static void main(String args[]) {
        MyGradebook gb = new MyGradebook();
        gb.reportGrade();
    }
}