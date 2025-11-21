/**
 * ArrayUtilTest.java
 *
 * Purpose: Unit test of the ArrayUtil class.
 *
 * @version 1.0 1/25/03
 * @author Ed Parrish
 */
public class ArrayUtilTest {
    /**
     * The main method begins execution of the tests.
     *
     * @param args not used
     */
    public static void main(String args[]) {
        testMakeArray();
        testCopyArray();
        testBubbleSort();
        testBubbleSortPlus();
        testLinearSearch();
        testBinarySearch();
        testShowArray();
        testShowArray2();
        testRunTests();
        testMain();
        System.out.println("*** All tests passed ***");
    }

    /**
     * Convenience method to test for assertions.
     *
     * @param condition The test condition that must be true to pass.
     * @param message The reason for the failure.
     */
    public static void assert2(boolean condition, String message) {
        if (!condition) {
            throw new RuntimeException(message);
        }
    }

    /**
     * Test method: int[] makeArray(int)
     */
    public static void testMakeArray() {
        System.out.println("Testing makeArray");
        int[] array = ArrayUtil.makeArray(10);
        assert2(array.length == 10, "Wrong array length");
        for (int i = 0; i < array.length; i++) {
            assert2(array[i] >= ArrayUtil.low, "Array value too low");
            assert2(array[i] < ArrayUtil.high, "Array value too high");
        }
    }

    /**
     * Test method: int[] copyArray(int[])
     */
    public static void testCopyArray() {
        System.out.println("Testing copyArray");
        int a[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] a2 = ArrayUtil.copyArray(a);
        assert2(a.length == a2.length, "Wrong array length");
        for (int i = 0; i < a.length; i++) {
            assert2(a[i] == a2[i], "Wrong array value");
        }
        a[0] = 99;
        assert2(a[0] != a2[0], "Array not copied");
    }

    /**
     * Test method: void bubbleSort(int[])
     */
    public static void testBubbleSort() {
        System.out.println("Testing bubbleSort");
        int a[] = {22, 12, 17, 29, 5, 67, 99, 0, 87, 43};
        ArrayUtil.bubbleSort(a);
        assert2(a.length == 10, "Wrong array length");
        for (int i = 0; i < a.length - 1; i++) {
            assert2(a[i] < a[i + 1],
                "Array not sorted: " + a[i] + "," + a[i + 1]);
        }
    }

    /**
     * Test method: void bubbleSortPlus(int[])
     */
    public static void testBubbleSortPlus() {
        System.out.println("Testing bubbleSortPlus");
        int a[] = {22, 12, 17, 29, 5, 67, 99, 0, 87, 43};
        ArrayUtil.bubbleSortPlus(a);
        assert2(a.length == 10, "Wrong array length");
        for (int i = 0; i < a.length - 1; i++) {
            assert2(a[i] < a[i + 1],
                "Array not sorted: " + a[i] + "," + a[i + 1]);
        }
    }

    /**
     * Test method: int linearSearch(int[], int)
     */
    public static void testLinearSearch() {
        System.out.println("Testing linearSearch");
        int a[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int index = ArrayUtil.linearSearch(a, 5);
        assert2(a.length == 10, "Wrong array length");
        assert2(index == 4, "Found wrong element index");
        index = ArrayUtil.linearSearch(a, 99);
        assert2(index == -1, "Found non-existant element");
    }

    /**
     * Test method: int binarySearch(int[], int)
     */
    public static void testBinarySearch() {
        System.out.println("Testing binarySearch");
        int a[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int index = ArrayUtil.binarySearch(a, 5);
        assert2(a.length == 10, "Wrong array length");
        assert2(index == 4, "Found wrong element index");
        index = ArrayUtil.linearSearch(a, 99);
        assert2(index == -1, "Found non-existant element");
    }

    /**
     * Test method: void showArray(int[])
     */
    public static void testShowArray() {
        System.out.println("Testing showArray");
        int a[] = {1, 2, 3, 4, 5};
        System.out.print("- Should show numbers 1 to 5: ");
        ArrayUtil.showArray(a);
        assert2(a.length == 5, "Array length modified");
    }

    /**
     * Test method: void showArray(int[], int)
     */
    public static void testShowArray2() {
        System.out.println("Testing showArray");
        int a[] = {1, 2, 3, 4, 5};
        System.out.print("- Should show numbers 1 to 5: ");
        ArrayUtil.showArray(a, 0);
        assert2(a.length == 5, "Array length modified");
    }

    /**
     * Test method: void runTests(int[])
     */
    public static void testRunTests() {
        System.out.println("Testing runTests");
        int a[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        ArrayUtil.runTests(a);
        assert2(a.length == 10, "Array length modified");
    }

    /**
     * Test method: void main(String[])
     */
    public static void testMain() {
        System.out.println("Testing main for user interface");
        ArrayUtil.main(null);
    }
}
