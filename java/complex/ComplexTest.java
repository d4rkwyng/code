/**
 * CIS20  Asn5
 * ComplexTest.java
 * Purpose: Tests the Complex Class
 *
 * @author Derek Wood
 * @version 1.0 3/19/03
 */

public class ComplexTest {
    /**
     * The main program for the ComplexTest class
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        testComplex();
        testComplex2();
        testComplex3();
        testAdd();
        testSub();
        testMul();
        testDivide();
        testToString();
        testMain();
        System.out.println("*** All tests passed ***"); 
    }
    
    /**
     * Convenience method to test for assertions.
     *
     * @param condition The test condition that must be true to pass.
     * @param message The reason for the failure.
     */
    public static void assertTrue(boolean condition, String message) {
        if (!condition) {
            throw new RuntimeException(message);
        }
    }
     
    /**
     * Tests the Complex method
     *
     * @param not used
     */
    public static void testComplex() {
        System.out.println("Testing Complex()");
        Complex a = new Complex();
        assertTrue(a.getReal() == 0.0,
            "Real value wrong: " + a.getReal());
        assertTrue(a.getImaginary() == 0.0,
            "Imaginary value wrong: " + a.getImaginary());
    }

    
    /**
     * Tests the Complex method
     *
     * @param not used
     */    
    public static void testComplex2() {
        System.out.println("Testing Complex(double)");
        Complex a = new Complex(6.0);
        assertTrue(a.getReal() == 6.0,
            "Real value wrong: " + a.getReal());
        assertTrue(a.getImaginary() == 0.0,
            "Imaginary value wrong: " + a.getImaginary());
    }
    
    /**
     * Tests the Complex method
     *
     * @param not used
     */    
    public static void testComplex3() {
        System.out.println("Testing Complex(double, double)");
        Complex a = new Complex(6.0,4.0);
        assertTrue(a.getReal() == 6.0,
            "Real value wrong: " + a.getReal());
        assertTrue(a.getImaginary() == 4.0,
            "Imaginary value wrong: " + a.getImaginary());
    }
    
    /**
     * Tests the Complex addition method
     *
     * @param not used
     */    
    public static void testAdd() {
        System.out.println("Testing add(Complex)");
        Complex a, b, c;
        a = new Complex(5.0, 4.0);
        b = new Complex(4.0, 3.0);
        c = a.add(b);
        assertTrue(c.getReal() == 9.0,
            "Real value wrong: " + c.getReal());
        assertTrue(c.getImaginary() == 7.0,
            "Imaginary value wrong: " + c.getImaginary());
    }

    
    /**
     * Tests the Complex substraction method
     *
     * @param not used
     */    
    public static void testSub() {
        System.out.println("Testing sub(Complex)");
        Complex a, b, c;
        a = new Complex(5.0, 4.0);
        b = new Complex(4.0, 3.0);
        c = a.sub(b);
        assertTrue(c.getReal() == 1.0,
            "Real value wrong: " + c.getReal());
        assertTrue(c.getImaginary() == 1.0,
            "Imaginary value wrong: " + c.getImaginary());
    }
    
    /**
     * Tests the Complex multiplication method
     *
     * @param not used
     */    
    public static void testMul() {
        System.out.println("Testing mul(Complex)");
        Complex a, b, c;
        a = new Complex(5.0, 4.0);
        b = new Complex(4.0, 3.0);
        c = a.mul(b);
        assertTrue(c.getReal() == 8.0,
            "Real value wrong: " + c.getReal());
        assertTrue(c.getImaginary() == 31.0,
            "Imaginary value wrong: " + c.getImaginary());
    }
    
    /**
     * Tests the Complex division method
     *
     * @param not used
     */    
    public static void testDivide() {
        System.out.println("Testing div(Complex)");
        Complex a, b, c;
        a = new Complex(5.0, 4.0);
        b = new Complex(4.0, 3.0);
        c = a.div(b);
        assertTrue(c.getReal() == 1.28,
            "Real value wrong: " + c.getReal());
        assertTrue(c.getImaginary() == 0.04,
            "Imaginary value wrong: " + c.getImaginary());
    }
    
    /**
     * Tests the Complex toString method
     *
     * @param not used
     */    
    public static void testToString() {
        System.out.println("Testing toString()");
        Complex a = new Complex(5.0,4.0);
        assertTrue(a.toString().equals("(5.0,4.0)"),
            "String invalid: " + a.toString());
    }
    
    /**
     * Tests the Complex Main method
     *
     * @param not used
     */        
    public static void testMain() {
        System.out.println("Testing main()");
        Complex.main(null);
    }
}