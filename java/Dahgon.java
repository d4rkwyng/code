/**
 * CIS12  Asg9 (Final Assignment)
 * Dahgon.java
 * Purpose: Destroy the evil monster.
 * @author Derek Wood
 * @version 1.2 12.15.02
 *
 * @updates: 11.26.02 <bugs fixed>
 *           12.11.02 <GUI(buttons) added>
 *           12.15.02 <asg9 requirements>
 *
 * created on: 11.24.02
 */

import java.awt.*; //For layout manager//
import java.awt.event.*; //For Events//
import javax.swing.*; //For JOptionPane (GUI)//
import java.io.*; //For I/O//

public class Dahgon extends JFrame
        implements ActionListener {

	private JButton storyButton;
    private JButton msgButton;
    private JButton aboutButton;
    private JButton exitButton;

   /**
    * The main program for the Dahgon Class
    *
    * @param args -- not used
    */
    public static void main(String[] args) {
        System.out.println(
			"\n\n\n\n\n" +
			"                           Fyre Systems presents:" + "\n\n" +
        	"                       C a s t l e  o f  D a h g o n" + "\n\n\n" +
       		"                             @author Derek Wood" + "\n" +
       		"                                @version 1.2" + "\n\n\n\n");
        new Dahgon(); //Activates the GUI//
    }

   /**
    * Creates the GUI for the Program
    *
    * @param args -- not used
    */
    public Dahgon() {
        super("Castle of Dahgon v1.2");
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        //List of Buttons//
        storyButton = new JButton("Story");
        msgButton = new JButton("Start");
        aboutButton = new JButton("About");
        exitButton = new JButton("Exit");

        //Layout Manager//
        Container X = getContentPane();
        X.setLayout(new FlowLayout());

        //Adding Buttons//
        X.add(storyButton);
        X.add(msgButton);
        X.add(aboutButton);
        X.add(exitButton);

        //Event Handlers//
        storyButton.addActionListener(this);
        msgButton.addActionListener(this);
        aboutButton.addActionListener(this);
        exitButton.addActionListener(this);

		//Set size of Window (suggest: off for autowrap)//
        //setSize(300, 150);
        setVisible(true);
        pack();
    }

   /**
    * Actions which occur from EndUser's choice
    *
    * @param args -- not used
    */
    public void actionPerformed(ActionEvent e) { //Start Activated//
        if (e.getSource() == storyButton) {
            JOptionPane.showMessageDialog(null,
            "    In a distant land known as Dahgon, knights roamed\n" +
       		"the valley. They protected the innocent and conquered\n" +
      		"the evil, but something lurked in Dahgon's dungeon.\n" +
      		"A monster which has never been seen or yet... none who\n" +
     		"have lived to describe it.  King Dahgon IV has issued a\n" +
     	 	"request for a knight noble enough to destroy this\n" +
    		"foul demon and the reward of marrying his daughter,\n" +
    	   	"Princess Daffadill.","Castle of Dahgon story by Derek Wood",
            JOptionPane.WARNING_MESSAGE);
        } else if (e.getSource() == msgButton) {
            JOptionPane.showMessageDialog(null,
            "Welcome noble knight! You have entered the city of Dahgon.",
            "City of Dahgon",JOptionPane.INFORMATION_MESSAGE);
            Quest(); //Starts the Quest//
        } else if (e.getSource() == aboutButton) { //About Dialog//
            JOptionPane.showMessageDialog(null,
            "    Dahgon is based on the classic medieval story\n" +
            "of knights rescuing a lost maiden in search of\n" +
            "her hand in marriage.  It is the final assignment\n" +
            "I did for CIS 12.\n" +
            "                 @author: Derek Wood\n" +
            "                 @version 1.2 12/15/02",
            "About Castle of Dahgon",
            JOptionPane.WARNING_MESSAGE);
        } else if (e.getSource() == exitButton) { //Exit//
			System.out.println("\nThank you for playing!" +
							   "\nVisit our website: http://www.fyresystems.com");
            System.exit(0);
        }
	}

   /**
    * Beginning of the storyline
    *
    * @param args -- not used
    */
    public void Quest() {
        String[] passData = new String[2];
        boolean checkanswer = true;
        String userIn = "";
        String name = "";
        String sword = "";

		JOptionPane.showMessageDialog(null,
    		"You proceed into Dahgon.  Dahgon looks like a peaceful" +
    		" place.\nThere are many small shops of all sorts.",
    		"So the quest begins...",JOptionPane.INFORMATION_MESSAGE);
		JOptionPane.showMessageDialog(null,
			"You browse along through the shops and a shimmering" +
    		" blade catches your eye.\nA long broadsword lays on a" +
    		" strip of brown cloth. It entitles: 'Excalibur 2.'");

		while (checkanswer == true) {
    		//Yes or No Option//
	        userIn = JOptionPane.showInputDialog(
            	"As you rub your hand along gold handle, the shop-" +
           		"keeper remarks,\n'Ah.. yes the Excalibur 2. The most" +
           		" prized sword in all of Dahgon.\nDo you like it?'" +
           		" (yes: <y> -- no: <n>)");
        	//Selection indicated//
        	try {
        		if ((userIn.equals("y")) || (userIn.equals("Y"))) {
        			JOptionPane.showMessageDialog(null,
        				"'Ah hah! I knew you would.  You have the look of a" +
        				" warrior, it fits you well.  I could sell it to you," +
       					" 260 rubles.'");
        			JOptionPane.showMessageDialog(null,
        				"You reply, 'I have nothing....'");
        			JOptionPane.showMessageDialog(null,
       					"The shop-keeper replies, 'Bah... be gone with you.'");
        			JOptionPane.showMessageDialog(null,
        				"You browse through a few more shops and see something\n" +
        				"which interests you, 'Palms and Fortune.'");
        			JOptionPane.showMessageDialog(null,
      					"Inside the tent it's very dark and only a light glow\n" +
        				"from a round ball lights the interior.  A voice enters\n" +
        				"your head, 'How may I be of service to thee, noble knight?'");
        			JOptionPane.showMessageDialog(null,
        				"A very old woman comes from behind a curtain in the rear\n" +
        				"of inside the tent.  Her face is covered.");
        			JOptionPane.showMessageDialog(null,
        				"She removes the cloth hiding her face and reveals\n" +
        				"a bald head with two black eyes.");
        			JOptionPane.showMessageDialog(null,
        				"'Don't be frightened,' she says.\n" +
        				"'I know why you've come.'");
        			JOptionPane.showMessageDialog(null,
        				"'And why is that,' you reply.");
        			JOptionPane.showMessageDialog(null,
        				"'You seek assistance from me,' she explains.");
        			JOptionPane.showMessageDialog(null,
        				"'And I can help you... you will need this,' she hands you\n" +
        				"a sword, on the handle it entitles: 'Broadsword of the Heavens.'\n" +
        				"\n\n(you receive the Broadsword of the Heavens)");
					sword = "Broadsword of the Heavens";
        			name = JOptionPane.showInputDialog(
        				"'What is they name, noble knight?'");
        			JOptionPane.showMessageDialog(null,
        				"You think to yourself, she knows why I'm here,\n" +
        				"but she doesn't even know my name.");
        			JOptionPane.showMessageDialog(null,
        				"'Now, " + name + ", You must go to the castle\n" +
        				"and free Princess Dafidill from the vile beast\n" +
        				"of the dungeons. In return, a bride and fame.'");
        			JOptionPane.showMessageDialog(null,
        				"'No knight has succeeded this quest, but I sense that\n" +
        				"you will... now go,' she vanishes.");
        			checkanswer = false;
				} else if ((userIn.equals("n")) || (userIn.equals("N"))) {
        			JOptionPane.showMessageDialog(null,
        				"'Ah... too bad, well we don't get many customers here,\n" +
        				"ever since that monster invaded Dahgon's dungeon. It's\n" +
        				"been sheer chaos. Noble knights venturing off to destroy\n" +
        				"that vile beast in return of Princess Dafidill's hand in" +
        				" marriage,\nbut not one knight has returned from the dungeon" +
        				"... alive.'");
        			JOptionPane.showMessageDialog(null,
        				"You reply: 'This monster, what is it?'");
        			JOptionPane.showMessageDialog(null,
        				"The shop-keeper whispers: 'No one knows..., but if your\n" +
        				"planning on taking it on alone, please take the sword free\n" +
        				"of charge.'\n\n(you receive the Excalibur 2)");
        			sword = "Excalibur 2";
        			name = JOptionPane.showInputDialog(
        				"'By the way, What be the name of this knight?'");
        			JOptionPane.showMessageDialog(null,
        				"You reply: 'My name is '" + name + "' kind sir and\n" +
        				"where may I find this dungeon?");
        			JOptionPane.showMessageDialog(null,
        				"He replies: '" + name + ", you must head towards the castle, there you\n" +
        				"shall find your way.'");
        			JOptionPane.showMessageDialog(null,
        				"You thank him briefly, and head north towards the castle.");
        			checkanswer = false;
				} else { //Error Message//
        	    JOptionPane.showMessageDialog(null,
        	       	"Fellow knight, your entry: <" + userIn + "> is invalid\n"
        	        + "Please try again!","Error",JOptionPane.ERROR_MESSAGE);
        	    }
			} catch (Exception e) {
       	    	JOptionPane.showMessageDialog(null,
       	       		"You can't cancel now!",
       	       		"Chicken",JOptionPane.ERROR_MESSAGE);
				userIn = "null";
			}
	 	} //End of While Loop//

	 	passData[0] = name;
	 	passData[1] = sword;
	 	Castle(passData); //To the Castle//
	}

   /**
    * The climax of the story....
    *
    * @param args -- not used
    */
	public void Castle(String[] catchData) {
        boolean checkanswer = true;
		String userIn = "";
		String name = catchData[0];
		String sword = catchData[1];

	    JOptionPane.showMessageDialog(null,
        	"As you draw nearer to the castle you can't help but notice the smell of decayed\n" +
      	  	"human flesh and occasional blood stains amongst the bricks of the castle.");
      	JOptionPane.showMessageDialog(null,
    	   	"The castle seems like an abandoned ruin.  It looks as if nothing exists, anymore\n" +
        	"You walk into what seems to be a throne room.  In the center is a huge carved stone.");
       	JOptionPane.showMessageDialog(null,
  			"The stone reads, 'To all noble knights who seek fame and fortune, this castle and\n" +
      	 	"my captured daughter is thine if you can slay the beast hidden in our dungeon.\n");
      	JOptionPane.showMessageDialog(null,
        	"You think to yourself, 'How odd...'");
      	JOptionPane.showMessageDialog(null,
       		"On the castle floor lay piles of charred defeated knights,\n" +
       		"Their sword, their sheild could not slay this horrid fright.\n",
       		"Poem",JOptionPane.INFORMATION_MESSAGE);
      	JOptionPane.showMessageDialog(null,
      		"In the dungeon, a creepy smell,\n" +
       		"Mist of darkness, a crevice of hell.\n",
       		"Poem",JOptionPane.INFORMATION_MESSAGE);
       	JOptionPane.showMessageDialog(null,
       		"Your hand trembles as you feel along the wall, in search of this creature.\n" +
       		"If only there were some form of light so you could find your way.\n");
      	JOptionPane.showMessageDialog(null,
       		"As you make your way around the next archway.\n" +
       		"You see a glimpse of a glowing light ahead.\n");
       	JOptionPane.showMessageDialog(null,
       		"There it lies, the demon of the night.\n" +
       		"Thy soul shivers cold, at it's sight.\n",
       		"Poem",JOptionPane.INFORMATION_MESSAGE);
       	JOptionPane.showMessageDialog(null,
       		"You draw your sword and make way towards the sleeping creature.\n" +
       		"Carefully walking to avoid awaking it, it would be your death.\n");
        while (checkanswer == true) {
   	    	userIn = JOptionPane.showInputDialog(
   		       	"You grasp hold of the " + sword + " and hover above the creature's head.\n" +
    	   		"What would you like to do?\n" +
    	   	   	"Enter 'c' to chop off the creature's head or 'd' to drop your sword.");
       		//Selection indicated//
			try {
       			if ((userIn.equals("c")) || (userIn.equals("C"))) {
       				JOptionPane.showMessageDialog(null,
       					"As your sword lifts in the air, the creature senses your presence.\n" +
       					"It knocks the sword out of your hands and looms above you...\n\n" +
      					"You're doomed.");
      				JOptionPane.showMessageDialog(null,
       					"The flames of darkness overwelm thee.\n" +
       					"The End.");
       				checkanswer = false;
				} else if ((userIn.equals("d")) || (userIn.equals("D"))) {
      				JOptionPane.showMessageDialog(null,
      					"You drop your sword and it's touch upon the floor shatters.\n" +
       					"The dark becomes light and the truth is revealed.");
       				JOptionPane.showMessageDialog(null,
       					"The creature which seemed a demon, was... now a princess.");
       				JOptionPane.showMessageDialog(null,
       					"'But... how?...'");
       				JOptionPane.showMessageDialog(null,
       					"Princess Dafidill arises from the once cracked tile.");
       				JOptionPane.showMessageDialog(null,
       					"She speaks, 'I have been trapped in a demon's body.\n" +
       					"Only the destruction of the sword " + sword + " could release my freedom.'");
       				JOptionPane.showMessageDialog(null,
       					"If the night has fallen and arisen a day.\n" +
       					"A hand in marriage assumes thy pay.",
       					"Poem",JOptionPane.INFORMATION_MESSAGE);
       				JOptionPane.showMessageDialog(null,
       					"Forever love, drips from the sky,\n" +
       					"A hand to hold, no tears from an a eye.",
       					"Poem",JOptionPane.INFORMATION_MESSAGE);
       				JOptionPane.showMessageDialog(null,
   						"In the lands of Dahgon,\n" +
       					"A hero is born.",
   						"~Fin~",JOptionPane.INFORMATION_MESSAGE);
       					checkanswer = false;
				} else { //Error Message//
           			JOptionPane.showMessageDialog(null,
           	 	  		"Fellow knight, your entry: <" + userIn + "> is invalid\n" +
           	 		   	"Please try again!","Error",JOptionPane.ERROR_MESSAGE);
           		}
			} catch (Exception e) {
       	    	JOptionPane.showMessageDialog(null,
       	       		"You can't cancel now, " + name + "!",
       	       		"Chicken",JOptionPane.ERROR_MESSAGE);
				userIn = "null";
			}
		} //End of While Loop//

		try {
   			Output(catchData);
		} catch(java.io.IOException e) {
			System.out.println("Error Exception: " + e.getMessage());
			System.exit(0);
			}
    	JOptionPane.showMessageDialog(null,
    	    "Thank you for playing, " + name + "!","Thank You",JOptionPane.INFORMATION_MESSAGE);
    }

   /**
    * Outputs Results to 'result.txt'
    *
    * @param args -- not used
    */
	public void Output(String[] catchData)
			throws IOException {
		//temp//
		String name = catchData[0];
		String sword = catchData[1];

		FileWriter fw = new FileWriter("Results.txt");
		BufferedWriter buf = new BufferedWriter(fw);
		PrintWriter doc = new PrintWriter(buf);
		doc.println("Castle of Dahgon - Results");
		doc.println("Name: " + name);
		doc.println("Sword: " + sword);
		doc.println();
		doc.println("Thank you for playing Castle of Dahgon!");
        doc.close();
	}
} //End of Dahgon Class File//