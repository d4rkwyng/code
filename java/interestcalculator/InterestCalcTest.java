/**
 * InterestCalcTest.java
 *
 * Purpose: Unit test of the InterestCalculator class.
 *
 * @version 1.0 1/24/03
 * @author Ed Parrish
 */
public class InterestCalcTest {
    /**
     * The main method begins execution of the tests.
     *
     * @param args not used
     */
    public static void main(String args[]) {
        testExp();
        testFinalValue();
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
     * Test method: double exp(double)
     */
    public static void testExp() {
        System.out.println("Testing exp");
        for (double power = 0.0; power < 1.5; power += 0.01) {
            double icexp = InterestCalculator.exp(power);
            double jmexp = Math.exp(power);
            assert2(Math.abs(icexp - jmexp) < 0.00001,
                "Method exp not accurate:" + power);
        }
    }

    /**
     * Test method: double finalValue(double, double, double)
     */
    public static void testFinalValue() {
        System.out.println("Testing finalValue");
        double value = InterestCalculator.finalValue(100.0, 0.05, 2.0);
        double target = 110.51709180756477;
        assert2(Math.abs(value - target) < 0.001,
            "Method finalValue not accurate: " + value + "s/b: " + target);
        value = InterestCalculator.finalValue(100.0, 0.10, 10.0);
        target = 271.8281828459045;
        assert2(Math.abs(value - target) < 0.001,
            "Method finalValue not accurate: " + value + "s/b: " + target);
    }

    /**
     * Test method: void main(String[])
     */
    public static void testMain() {
        System.out.println("Testing main for user interface");
        InterestCalculator.main(null);
    }
}
