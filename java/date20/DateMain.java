import javax.swing.*;
import java.awt.event.*;
import java.awt.*;
import java.io.*;

/**
 * CIS20  Asn 9
 * DateMain.java
 * Purpose: Calls the Data.java methods to analyze input data.
 *
 * @author Derek Wood
 * @version 1.0 4/30/03
 */
public class DateMain extends JFrame
        implements ActionListener {
    private JLabel mmlabel;
    private JLabel ddlabel;
    private JLabel yyyylabel;
    private JLabel ndlabel;
    private JLabel result;
    private JTextField mmfield;
    private JTextField ddfield;
    private JTextField yyyyfield;

    /**
     * Calls the DateMain() to create the input window object
     *
     * @param args -- not used
     */
    public static void main (String args[]) {
        new DateMain();
    }

    /**
     * Creates the input window object
     */
    public DateMain() {
        super("Date");
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        mmlabel = new JLabel("mm");
        ddlabel = new JLabel("dd");
        yyyylabel = new JLabel("yyyy");

        ndlabel = new JLabel("The next day is: ");
        result = new JLabel("");

        mmfield = new JTextField(5);
        ddfield = new JTextField(5);
        yyyyfield = new JTextField(5);

        Container X = getContentPane();
        X.setLayout(new GridLayout(3, 3, 5, 5));

        //Row 1
        X.add(mmlabel);
        X.add(ddlabel);
        X.add(yyyylabel);
        //Row 2
        X.add(mmfield);
        X.add(ddfield);
        X.add(yyyyfield);
        //Row 3
        X.add(ndlabel);
        X.add(result);

        mmfield.addActionListener(this);
        ddfield.addActionListener(this);
        yyyyfield.addActionListener(this);

        setVisible(true);
        pack();
    }

    /**
     * Converts the input if keyascii 13 or 'enter' is pressed (action)
     *
     * @param e -- ActionEvent
     */
    public void actionPerformed(ActionEvent e) {
        try {
            if (e.getSource() == yyyyfield) {
                int mm, dd, yyyy;
                mm = Integer.parseInt(mmfield.getText());
                dd = Integer.parseInt(ddfield.getText());
                yyyy = Integer.parseInt(yyyyfield.getText());
                Date today = new Date();
                today.setDate(yyyy, mm, dd);
                if (today.isValid() == true) {
                    today.nextDay();
                    result.setText(today.toString());
                } else
                    result.setText("Invalid Entry");
            }
        } catch(Exception m) {
            JOptionPane.showMessageDialog(null, m.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
}