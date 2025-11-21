/**
 * CIS20  Asn5
 * Complex.java
 * Purpose:
 *
 * @author Derek Wood
 * @version 1.0 3/18/03
 */

public class Complex {
    // Represents the complex number real and imaginary selections
    private double RNum, INum;
    
    /**
     * The main program for the ComplexTest class
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Numbers coulld be read in as arguments
        double real1 = 5, real2 = 4, imag1 = 4, imag2 = 3;
        boolean checkanswer = true;
          
        while (checkanswer == true) {
            System.out.println("Please enter 'm' to manually enter in the numbers" +
                ", or enter 'a' to automatically use the internal numbers.");
            String Input = Console.readLine();
            if ((Input.equals("a")) || (Input.equals("A"))) {
                checkanswer = false;
            } else if ((Input.equals("m")) || (Input.equals("M"))) {
                System.out.print("Enter real one: ");
                real1 = Console.readDouble();
                System.out.print("Enter real two: ");
                real2 = Console.readDouble();
                System.out.print("Enter imaginary one: ");
                imag1 = Console.readDouble();
                System.out.print("Enter imaginary two: "); 
                imag2 = Console.readDouble();
                checkanswer = false;
            } else {
                System.out.println("Your input: <" + Input + "> is an invalid entry.\n");
            }
        }
        
        checkanswer = true;
        while (checkanswer == true) {
            // Initial Assignment
            Complex Set1 = new Complex(real1, imag1);
            Complex Set2 = new Complex(real2, imag2);

            // Addition Call
            Complex Ans1 = Set1.add(Set2);
            System.out.println("Sum = " + Ans1.toString());

            // Reset First Number
            Complex reset = new Complex();
            Set1 = new Complex(real1, imag1);

            // Subtraction Call
            Complex Ans2 = Set1.sub(Set2);
            System.out.println("Difference = " + Ans2.toString());

            // Reset First Number
            Complex reset2 = new Complex();
            Set1 = new Complex(real1, imag1);

            // Multiplication Call
            Complex Ans3 = Set1.mul(Set2);
            System.out.println("Product = " + Ans3.toString());

            // Reset First Number
            Complex reset3 = new Complex();
            Set1 = new Complex(real1, imag1);

            // Division Call
            Complex Ans4 = Set1.div(Set2);
            System.out.println("Factor = " + Ans4.toString());
            checkanswer = false;
        }
     }
     
    /**
     * Default Constructor
     *
     * @param not used
     */
    public Complex() {
        RNum = 0;
        INum = 0;
    }
 
    /**
     * Real and Imaginary Definition
     *
     * @param r the real number set 
     * @param i the imaginary number set
     */
    public Complex(double r, double i) {
        RNum = r;
        INum = i;
    }
    
    /**
     * Real Declarition
     *
     * @param r the real set and imaginary set to 0
     */  
    public Complex(double r) {
        RNum = r;
        INum = 0;
    }
    
    /**
     * Real and Imaginary Definition
     *
     * @param other the overload constructor
     */
    public Complex(Complex other) {
        RNum = other.RNum;
        INum = other.INum;
    }

     /**
      * Adds two Complex numbers. The real parts are added together and the
      *  imaginary parts are added together. 
      *
      * @param AStmt the addition constructor
      */
     public Complex add(Complex AStmt) {
         RNum += AStmt.RNum;
         INum += AStmt.INum;
         return this;
     }
     
     /**
      * Subtracts two Complex numbers. The real part of the right operand is
      *  subtracted from the real part of the left operand.
      *
      * @param AStmt the substraction constructor
      */
     public Complex sub(Complex SStmt) {
         RNum -= SStmt.RNum;
         INum -= SStmt.INum;
         return this;
     }
     
     /**
      * Divides two Complex numbers.
      *
      * @param DStmt the division constructor
      */
     public Complex div(Complex DStmt) {
         double R, I, D;
         /**
          * R is the real numerator
          * I is the imaginary numerator
          * D is the denominator
          */
         R = (RNum * DStmt.RNum) + (INum * DStmt.INum);
         I = (RNum * DStmt.INum * -1) + (INum * DStmt.RNum);
         D = (DStmt.RNum * DStmt.RNum) + (DStmt.INum * DStmt.INum);       
         RNum = R / D;
         INum = I / D;
         return this;
     }
     
     /**
      * Multiplies two Complex numbers.
      *
      * @param MStmt the multiplication constructor
      */
     public Complex mul(Complex MStmt){
         double Rval = (RNum * MStmt.getReal()) - (INum * MStmt.getImaginary());
         double Ival = (RNum * MStmt.getImaginary()) + (INum * MStmt.getReal());
         
         RNum = Rval;
         INum = Ival;
         return this;
     }
     
     /**
      * Prints the Complex number in the form (a, b), where a is the real
      *  part and b is the imaginary part.
      *
      * @param not used
      */
     public String toString() {
         return "(" + RNum + "," + INum + ")";
     }
     
     /**
      * Returns the Imaginary value
      *
      * @param not used
      */
     public double getImaginary() {
         return INum;
     }

     /**
      * Returns the Real value
      *
      * @param not used
      */
     public double getReal() {
         return RNum;
     }
}