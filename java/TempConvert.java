/**
 * CIS12  Asg3
 * TempConvert.java
 * Purpose: Converts from Farenheit to Celcius
 *
 * @author Derek Wood
 * @version 1.0 9/17/02
 */

    import javax.swing.*;

class TempConvert
{
   /**
    * The main program for the TempConvert class
    *
    * @param args -- not used
    */
    public static void main(String[] args)
    {
        String inputF = JOptionPane.showInputDialog(
            "Enter a temperature in degrees Farenheit: ");
       /**
        * Convertion and formula
        */
        double degreesF = Double.parseDouble(inputF);
        double degreesC = 5 * (degreesF - 32)/9;

        JOptionPane.showMessageDialog(null, degreesF
            + " Farenheit = " + degreesC
            + " Celsius.");

        System.exit(0); // ends the program
     }//end method main
}//end class TempConvert