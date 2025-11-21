import java.awt.*;
import java.lang.*;
import javax.swing.*;

/**
 * CIS20  Asn 6
 * MyShape.java
 * Purpose: Draws the shapes from the ArtOMatic Class
 *
 * @author Derek Wood
 * @version 1.0 4/9/03
 */
public abstract class MyShape extends JFrame {
    private int x1, x2, y1, y2;
    private int choice;

    /**
     * Sets the default values
     *
     * @param args -- not used
     */
    public MyShape() {
        x1 = 0;
        x2 = 0;
        y1 = 0;
        y2 = 0;
        choice = 0;
    }

    /**
     * Sets the values
     *
     * @param x - x1 value, y - y1 value, w - width, h - heighth, c - choice
     */
    public MyShape(int x, int y, int w, int h, int c) {
        x1 = x;
        y1 = y;
        x2 = w;
        y2 = h;
        choice = c;
    }

    /**
     * Draw shapes
     *
     * @param g graphics context
     */
    public void draw(Graphics g) {
        String MyChoice = "";
        switch (choice) {
            case 1:
                MyChoice = "MyLine";
                g.drawLine(x1, y1, x2, y2);
                break;
            case 2:
                MyChoice = "MyOval";
                g.drawOval(x1, y1, x2, y2);
                break;
            case 3:
                MyChoice = "MyRect";
                g.drawRect(x1, y1, x2, y2);
                break;
            case 4:
                MyChoice = "My3DRect";
                g.draw3DRect(x1, y1, x2, y2, false);
                break;
            default:
                g.drawString("Invalid Entry", 10, 50);
                break;
        }
        /**
         * Outputs each time it draws the shapes.  By resizing the window, this is called.
         * Might be wise to just null this out, but left from instructor's test example.
         */
        System.out.println(MyChoice + ": x1 = " + x1 + ", y1 = " + y1 + ", width = " + x2 + ", height = " + y2);
    }
}