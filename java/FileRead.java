import java.io.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.filechooser.*;

/**
 * CIS20  Asn 10
 * FileRead.java
 * Purpose: The user enters a file name in the text field and presses the enter key. 
 *          The program loads the file and is displays it in the text area. 
 *          If the file cannot be found, the program displays an error message. 
 *
 * @author Derek Wood
 * @version 1.0 5/07/03
 */
public class FileRead extends JPanel
        implements ActionListener {
    static private final String newline = "\n";
    JButton openButton, saveButton, clearButton;
    JFileChooser fc;
    JTextField input;
    JEditorPane box;
    //JTextArea box;
    
    /**
     * Creates the input window object
     */
    public FileRead() {
        //Create the box first, because the action listeners need to refer to it.
        //box = new JTextArea(5,20);
        box = new JEditorPane();
        box.setMargin(new Insets(5,5,5,5));
        JScrollPane boxScrollPane = new JScrollPane(box);

        //Create a file chooser
        fc = new JFileChooser();

        //Create text field
        input = new JTextField(20);
        input.addActionListener(this);

        //Create the buttons
        //Open button
        openButton = new JButton("Open");
        openButton.addActionListener(this);

	//Save button
        saveButton = new JButton("Save");
        saveButton.addActionListener(this);

	//Clear button
        clearButton = new JButton("Clear");
        clearButton.addActionListener(this);

        //For layout purposes, put the buttons in a separate panel
        JPanel buttonPanel = new JPanel();
        buttonPanel.add(input);
        buttonPanel.add(openButton);
        buttonPanel.add(saveButton);
        buttonPanel.add(clearButton);

        //Add the buttons and the log to this panel.
        setLayout(new BorderLayout());
        add(buttonPanel, BorderLayout.PAGE_START);
        add(boxScrollPane, BorderLayout.CENTER);
    }

    /**
     * Converts the input if keyascii 13 or 'enter' is pressed (action)
     *
     * @param e -- ActionEvent
     */
    public void actionPerformed(ActionEvent e) {
	try {
            //Handle input field action
            if (e.getSource() == input) {
                insertData(input.getText());
            //Handle open button action.
            } else if (e.getSource() == openButton) {
                int returnVal = fc.showOpenDialog(FileRead.this);
		if (returnVal == JFileChooser.APPROVE_OPTION) {
                    File file = fc.getSelectedFile();
                    //This is where a real application would open the file.
                    insertData(file.getPath());
		}
            //Handle save button action.
            } else if (e.getSource() == saveButton) {
                int returnVal = fc.showSaveDialog(FileRead.this);
		if (returnVal == JFileChooser.APPROVE_OPTION) {
                    File file = fc.getSelectedFile();
                    //This is where a real application would save the file.
                    JOptionPane.showMessageDialog(null, "The file: " + file.getName() + " was saved", "File Saved", JOptionPane.INFORMATION_MESSAGE);
		}
            } else if (e.getSource() == clearButton) {
		box.setText("");
            }
        } catch(Exception m) {
            JOptionPane.showMessageDialog(null, m.getMessage(), "Message", JOptionPane.INFORMATION_MESSAGE);
        }
    }

    /**
     * Inserts file data into the text box
     *
     * @param file - The file to open
     */
    public void insertData(String file)
            throws java.io.IOException {
        box.setText("");
        FileReader fr = new FileReader(file);
        BufferedReader in = new BufferedReader(fr);
        String msgread = in.readLine();
        String msgfull = "";
        while (msgread != null) {
            if (msgfull == "")
                msgfull = msgread;
            else
                msgfull = msgfull + newline + msgread;
            msgread = in.readLine();
            box.setText(msgfull);
        }
        input.setText(file);
        in.close();
    }

    /**
     * Calls the FileRead() to create the input window object
     *
     * @param args -- not used
     */
    public static void main(String[] args)
            throws java.io.IOException {
        //Make sure we have nice window decorations.
        JFrame.setDefaultLookAndFeelDecorated(true);
        JDialog.setDefaultLookAndFeelDecorated(true);

        //Create and set up the window.
        JFrame frame = new JFrame("Display File");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setContentPane(new FileRead());

        //Display the window.
        //frame.pack();
        frame.setSize(600,400);
        frame.setVisible(true);
    }
}
