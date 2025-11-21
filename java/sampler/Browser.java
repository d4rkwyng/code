import javax.swing.text.html.*;
import javax.swing.text.*;
import javax.swing.event.*;
import javax.swing.*;
import java.io.*;
import java.awt.*;
import java.awt.event.*;
import java.util.*;

/**
 * CIS20  Sampler Project
 * List.java
 * Purpose: Browses the internet.  A basic webbrowser.
 *
 * @author Derek Wood
 * @version 1.1 5/28/03
 */
public class Browser {
	private String[] passData = new String[99];
	private JTextField inputBox;
	private int Count = 0;

	/**
	 * Sets the page to be viewed.
	 *
	 * @param jep -- the pane on which to display the url
	 * @param url -- the url to display
	 */
 	protected static void setPage(JEditorPane jep, String url){
		try {
			jep.setPage(url);
		}
		catch (IOException e) {
			System.err.println(e);
			System.exit(-1);
		}
	}

	/**
	 * Goes Back to the previous page visited.
	 */
	class backButtonListener implements ActionListener {
		protected JEditorPane jep;
		protected JLabel label;
		protected JButton backButton;
		protected Vector history;
		public backButtonListener(JEditorPane jep, JButton backButton, Vector history, JLabel label){
			this.jep = jep;
			this.backButton = backButton;
			this.history = history;
			this.label = label;
		}

		/**
		 * Show the last url in the history
		 *
		 * @param e -- the event
		 */
		public void actionPerformed(ActionEvent e){
			try{
				//the current page is the last, remove it
				String curl = (String)history.lastElement();
				history.removeElement(curl);

				curl = (String)history.lastElement();
				System.out.println("Backward: " + curl);
				passData[Count] = "+ Backward: " + curl;
				Count++;
				inputBox.setText(curl);
				setPage(jep,curl);
				label.setText("<html><b>URL:</b> "+ curl);
				if (history.size() == 1)
					backButton.setEnabled(false);
				}
			catch (Exception ex){
				System.out.println("Exception " + ex);
			}
		}
	}

	/**
	 * Goes to the Link Clicked
	 */
	class LinkFollower implements HyperlinkListener {
		protected JEditorPane jep;
		protected JLabel label;
		protected JButton backButton;
		protected Vector history;
		public LinkFollower(JEditorPane jep, JButton backButton, Vector history, JLabel label){
			this.jep = jep;
			this.backButton = backButton;
			this.history = history;
			this.label = label;
		}

		/**
		 * The action is to show the page of the URL the user clicked on.
		 *
		 * @param evt -- the event
		 */
		public void hyperlinkUpdate(HyperlinkEvent evt){
			if (evt.getEventType() == HyperlinkEvent.EventType.ACTIVATED){
				try {
					String currentURL = evt.getURL().toString();
					history.add(currentURL);
					backButton.setEnabled(true);
					System.out.println("Toward: " + currentURL);
					passData[Count] = "+ Toward: " + currentURL;
					Count++;
					inputBox.setText(currentURL);
					setPage(jep,currentURL);
					label.setText("<html><b>URL:</b> "+ currentURL);
				}
				catch (Exception e) {
					System.out.println("404: The page was not found.");
				}
			}
		}
	}

	/**
	 * The contructor runs the browser. It displays the main frame with the
	 *  fetched initialPage
	 *
	 * @param initialPage -- the first page to show
	 */
 	public Browser(String initialPage) {
		/**
		 * A vector of String containing the past urls
		 */
		passData[Count] = "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++";
		Count++;
		passData[Count] = "+                       Session Started";
		Count++;
		passData[Count] = "+";
		Count++;
		Vector history = new Vector();
		history.add(initialPage);

		JEditorPane jep = new JEditorPane();
		jep.setEditable(false);
		setPage(jep, initialPage);

		JScrollPane scrollPane = new JScrollPane(jep);
        JFrame.setDefaultLookAndFeelDecorated(true);
		JFrame f = new JFrame("Sampler Project: Web Browser");
		f.setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);

		//Exit the program when EndUser closes window
		f.addWindowListener(new WindowAdapter() {
				public void windowClosing(WindowEvent e) {
					lastCall();
				}
			});

		//Bottom Label URL
		JLabel label = new JLabel("<html><b>URL:</b> "+ initialPage);

		JButton backButton = new JButton ("Back");
		backButton.setActionCommand("back");
		backButton.setToolTipText("Go to previous page");
		backButton.setEnabled(false);
		backButton.addActionListener(new backButtonListener(jep, backButton, history, label));

		JButton exitButton = new JButton ("Exit");
		exitButton.setActionCommand("exit");
		exitButton.setToolTipText("Quit this application");
		exitButton.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					lastCall();
				}
			});

        inputBox = new JTextField(30);
        inputBox.setText(initialPage);
        inputBox.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent e) {
					String initialPage = new String(inputBox.getText());
					Browser b = new Browser(initialPage);
				}
			});

		//A toolbar to hold the buttons
		JToolBar toolBar = new JToolBar();
		toolBar.add(backButton);
		toolBar.add(exitButton);

		JPanel buttonPanel = new JPanel();
        buttonPanel.add(inputBox);
        buttonPanel.add(toolBar);

		jep.addHyperlinkListener(new LinkFollower(jep, backButton, history, label));

		//Set up the toolbar and scrollbar in the contentpane of the frame
		JPanel contentPane = (JPanel) f.getContentPane();
		contentPane.setLayout(new BorderLayout());
		contentPane.setPreferredSize(new Dimension(400, 100));
		contentPane.add(buttonPanel, BorderLayout.NORTH);
		contentPane.add(scrollPane, BorderLayout.CENTER);
		contentPane.add(label, BorderLayout.SOUTH);

		f.pack();
		f.setSize(700, 900);
		f.setVisible(true);
	}

	/**
	 * Create a Browser object. Use the command-line url if given
	 */
	public static void main(String[] args)
			throws IOException {
        FileReader fr = new FileReader("homepage.txt");
        BufferedReader in = new BufferedReader(fr);
		String initialPage = in.readLine();
		if (args.length > 0) initialPage = args[0];
		Browser b = new Browser(initialPage);
	}

	public void lastCall() {
		try {
   			Output(passData);
		} catch(java.io.IOException e) {
			System.out.println("Error Exception: " + e.getMessage());
			System.exit(0);
		}
	}

   /**
    * Outputs Results
    *
    * @param catchData -- the Data to be added
    */
	public void Output(String[] catchData)
			throws IOException {
		FileWriter fw = new FileWriter("history.txt");
		BufferedWriter buf = new BufferedWriter(fw);
		PrintWriter doc = new PrintWriter(buf);
		for (int i = 0; i < catchData.length; i++) {
			if (catchData[i] == null) {
			} else {
				doc.println(catchData[i]);
			}
		}
		doc.println("+");
		doc.println("+                       Thank you!");
		doc.println("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        doc.close();
        System.exit(0);
	}
}