/**
 * CIS20  Asn4
 * ArrayUtil.java
 * Purpose: Sorts user's inputed number into numerical order and
 *          displays results.
 * @author Derek Wood
 * @version 1.0 3/12/02
 */
public class ArrayUtil {
    final static int low = 0;
    final static int high = 1000;
    private static int comparisons = 0;
    private static String sortanswer = "";

    /**
     * The main method begins execution of Java application.
     *
     * @param args not used
     */
    public static void main(String[] args) {
    	boolean checkanswer = true;
    	String Input = "";
    	int aS;
    	int size = -1;
		System.out.println("This program requests an array size from the user,\n" +
			"creates an array of that size filled with random numbers,\n" +
   			"and tests the array.\n");
        while (checkanswer == true) {
			System.out.print("Enter <b> for Bubble Sort or <s> for Selection Sort: ");
   			Input = Console.readLine();
        	// Selection indicated
        	if ((Input.equals("b")) || (Input.equals("B"))) {
            	sortanswer = "Bubble";
            	checkanswer = false;
			} else if ((Input.equals("s")) || (Input.equals("S"))) {
            	sortanswer = "Selection";
            	checkanswer = false;
			} else {
            	System.out.println("Your input: <" + Input + "> is an invalid entry.\n");
	 		}
	 	}

        checkanswer = true;
        while (checkanswer == true) {
		    System.out.print("Enter the array size to test (0 to exit): ");
        	aS = Console.readInt();

        	// Verifies EndUser's input (must be a postive integer)
        	size = aS;
        	if (size < 0) {
				System.out.println("Size cannot be a negative number!");
            } else if (size == 0) {
				System.out.println("Good-Bye");
				System.exit(0);
			} else {
            	checkanswer = false;
            }
		}
	 	int[] array = makeArray(size);
        runTests(array); //Runs the test
    }

    /**
     * Runs tests on the int array.
     *
     * @param array The array to test.
     */
    public static void runTests(int[] array) {
        System.out.println("Original array elements are:");
        showArray(array);
        int[] arrayCopy = copyArray(array);
        bubbleSort(arrayCopy);
        System.out.println("\n" + sortanswer + " Sort comparisons needed: "
            + comparisons);
        System.out.println("Sorted array elements are:");
        showArray(arrayCopy);
        arrayCopy = copyArray(array);
        bubbleSortPlus(arrayCopy);
        System.out.println("Enhanced " + sortanswer + " Sort comparisons needed: "
            + comparisons);
        showArray(arrayCopy, 0);
        int item = (int) (Math.random() * (array.length - 1));
        System.out.println("\nSearching for: " + array[item]);
        linearSearch(arrayCopy, array[item]);
        System.out.println("Linear search Comparisons needed: "
            + comparisons);
        binarySearch(arrayCopy, array[item]);
        System.out.println("Binary search Comparisons needed: "
            + comparisons);
    }

    /**
     * Creates the array.
     *
     * @param array The array to create.
     * @return array The created array.
     */
    public static int[] makeArray(int size) {
        int array[] = new int [size];
		int i;
		boolean checkanswer;
		String answer = "";
    	String outputline = "";
    	String outputline2 = "";
    	int temp;
		checkanswer = true;
        while (checkanswer == true) {
			// Options for Random or EndUser input
			System.out.print("Enter <e> for manual input or <r> for random (" + size + "#s from 1000): ");
        	answer = Console.readLine();

        	// Randomize (If EndUser input is 'r' or 'R')
        	if ((answer.equals("r")) || (answer.equals("R"))) {
            	for (i = 0; i < array.length; i++) {
                 	 /**
                      *  Randomizes any number between 1 - 999
                      *  The int range is -2147483648 to 2147483647
                      */
                     int r = (int)(Math.random() * high - 1);
                     array[i] = r;
                }
             	checkanswer = false;
        	} else if ((answer.equals("e")) || (answer.equals("E"))) {
            	for (i = 0; i < array.length; i++) {
					System.out.print("Enter integer #" + (i+1) + " of " + size + ": ");
                	temp = Console.readInt();
                	array[i] = temp;
            	outputline = outputline + " " + array[i];
            	checkanswer = false;
            	}
        	} else { // error message
            	System.out.println("Your input: <" + answer + "> is an invalid entry.\n"
                	+ "Please try again!");
	 		}
 		} return array;
    }

    /**
     * Copies the array.
     *
     * @param array The array to copy.
     * @returns array The copied array.
     */
    public static int[] copyArray(int[] array) {
        int newArray[] = new int [array.length];
        for (int i = 0; i < array.length; i++)
            newArray[i] = array[i];
        return newArray;
    }

    /**
     * Uses BubbleSort to sort the array.
     *
     * @param array The array to sort.
     */
    public static void bubbleSort(int[] array) {
		comparisons = 0;
		for (int i = 0; i < array.length - 1; i++) {
			for (int j = 0; j < array.length - 1; j++) {
				comparisons++;
				if (array[j] > array[j + 1]) swap(array, j, j + 1);
			}
		}
    }

    /**
     * Uses BubbleSort to sort the array.
     *  Not Completed
     *
     * @param array The array to sort.
     */
    public static void bubbleSortPlus(int array[]) {
		comparisons = 0;
		for (int i = 0; i < array.length - 1; i++) {
			for (int j = 0; j < array.length - 1; j++) {
				comparisons++;
				if (array[j] > array[j + 1]) swap(array, j, j + 1);
			}
		}
    }

    /**
     * Searches for even integers in the array.
     *
     * @param array The array to search.
     * @return int The value of comparisons.
     */
    public static int linearSearch(int[] array, int key) {
        comparisons = 0;
    	for (int i = 0; i < array.length; i++)
			for (int j = 0; j < array.length; j++) {
        		comparisons++;
        		if (array[j] == key) return key;
			}
      	return -1;  // key not found
    }

    /**
     * Searches using a Binary method (2^x)
     *
     * @param array The array to search.
     * @return int The value of comparisons.
     */
    public static int binarySearch(int[] array, int key) {
      	int low = 0;
      	int high = array.length - 1;
		int middle;
        comparisons = 0;
      	while (low <= high) {
			comparisons++;
         	middle = (low + high) / 2;
         	if (key == array[middle]) return middle;
			else if (key < array[middle]) high = middle - 1;
         	else low = middle + 1;
      	}
      	return -1;   // key not found
    }

    /**
     * Outputs the array, sort or unsorted.
     *
     * @param array The array to output.
     */
    public static void showArray(int[] array) {
		String hold = "";
        for (int i = 0; i < array.length; i++) {
            hold = array[i] + ", ";
        	System.out.print(hold);
		}
		System.out.println();
    }

    /**
     * Outputs the array recursively.
     *
     * @param array The array to output.
     */
    public static void showArray(int[] array, int start) {
        if (start == 0) {
			String hold = "";
        	for (int i = 0; i < array.length; i++) {
            	hold = array[i] + ", ";
        		System.out.print(hold);
			}
			System.out.println();
		}
    }

    /**
     * Swaps lower integers with higher integers.
     *
     * @param array The array to perform swap.
     */
	private static void swap(int[] array, int first, int second) {
		int hold = array[first];
		array[first] = array[second];
		array[second] = hold;
	}

    /**
     * Uses Selection Sort to sort the array.
     *
     * @param array The array to sort.
     */
	public static void selectionSort(int[] array) {
		comparisons = 0;
	 	int index, indexOfMin;
		for (index = 0; index < array.length - 1; index++) {
			indexOfMin = findMin(array, index);
			swap(array, index, indexOfMin);
			comparisons++;
		}
	}

    /**
     * Searches array for min. value.
     *
     * @param array The array to search.
     * @return int The min. value.
     */
	private static int findMin(int[] array, int start) {
		int indexOfMin = start;
		for (int i = start + 1; i <= array.length - 1; i++) {
			if (array[i] < array[indexOfMin]) {
				indexOfMin = i;
			}
		} return indexOfMin;
	}
}
