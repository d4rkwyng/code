import java.awt.*;
import java.lang.*;
import javax.swing.*;

/**
 * CIS20  Asn 6
 * ArtOMatic.java
 * Purpose: Randomly draw shapes
 *
 * @author Derek Wood
 * @version 1.0 4/9/03
 */
public class ArtOMatic extends JFrame {
    final int NUM_SHAPES = 16;
    private MyShape shapes[];
    
    /**
     * Contructor that tests drawing shapes 
     */
    public ArtOMatic() {
        //Sets application's title
        super("Art-O-Matic");
        shapes = new MyShape[NUM_SHAPES];
        
        MyShape a = new MyLine(152,223,273,327,1);
        MyShape b = new MyLine(109,25,447,260,1);
        MyShape c = new MyLine(265,426,215,46,1);
        MyShape d = new MyOval(115,137,54,191,2);
        MyShape e = new MyOval(47,253,286,117,2);
        MyShape f = new MyOval(70,291,350,185,2);
        MyShape g = new MyOval(367,260,156,218,2);
        MyShape h = new MyOval(60,317,208,230,2);
        MyShape i = new MyOval(288,107,66,273,2);
        MyShape j = new MyOval(195,159,20,76,2);
        MyShape k = new MyRect(208,69,59,381,3);
        MyShape l = new MyRect(431,447,286,239,3);
        MyShape m = new MyRect(349,458,41,114,3);
        MyShape n = new MyRect(251,277,76,156,3);
        MyShape o = new MyRect(283,413,42,199,3);
        //extra credit 4th draw sequence -- located in top right of window
        MyShape p = new My3DRect(5,100,90,55,4);
        
        shapes[0] = a;
        shapes[1] = b;
        shapes[2] = c;
        shapes[3] = d;
        shapes[4] = e;
        shapes[5] = f;
        shapes[6] = g;
        shapes[7] = h;
        shapes[8] = i;
        shapes[9] = j;
        shapes[10] = k;
        shapes[11] = l;
        shapes[12] = m;
        shapes[13] = n;
        shapes[14] = o;
        shapes[15] = p;
    }

    /**
     * Draw shapes
     * (changed g to gg for random rgb colors
     * @param gg graphics context
     */
    public void paint(Graphics gg) {
        // call superclass's paint method
        super.paint(gg);
        for (int i = 0; i < shapes.length; i++) {
            //sets random color to shape
            int r = (int)(Math.random() * 255);
            int g = (int)(Math.random() * 255);
            int b = (int)(Math.random() * 255);
            gg.setColor(new Color(r,g,b));
            shapes[i].draw(gg);
        }
    }

    /**
     * Create a TestDrawWindow object
     *
     * @param args -- not used
     */
    public static void main(String args[]) {
        ArtOMatic window = new ArtOMatic();
        window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        window.setSize(500, 500);
        window.show();
    }
}