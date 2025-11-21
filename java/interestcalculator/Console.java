import java.io.*;

/*
 * Console.java
 *
 * Purpose: Gets user input from the command line.
 *
 * @version 1.1 1/23/03
 * @author Ed Parrish
 */
public class Console {
    /**
     * Read a line of text from the shell console.
     *
     * @return A String input by the user.
     */
    public static String readLine() {
        BufferedReader in = new BufferedReader(
                new InputStreamReader(System.in));
        try {
            String line = in.readLine();
            return line;
        } catch(IOException ioe) {
            System.out.println("Input error: "
                    + ioe.getMessage());
            System.out.println("Please try again.");
            return readLine();
        }
    }

    /**
     * Read an int on a single line from the shell console.
     *
     * @return An int input by the user.
     */
    public static int readInt() {
        String line = readLine().trim();
        try {
            int number = Integer.parseInt(line);
            return number;
        } catch (NumberFormatException nfe) {
            System.out.println("Input error: "
                    + nfe.getMessage());
            System.out.println("Please try again.");
            return readInt();
        }
    }

    /**
     * Read a double on a single line from the shell console.
     *
     * @return A double input by the user.
     */
    public static double readDouble() {
        String line = readLine().trim();
        try {
            double number = Double.parseDouble(line);
            return number;
        } catch (NumberFormatException nfe) {
            System.out.println("Input error: "
                    + nfe.getMessage());
            System.out.println("Please try again.");
            return readDouble();
        }
    }
}
