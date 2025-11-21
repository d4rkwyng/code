Rem Test script for DecimalPalindrome
Rem Test if source code compiles
del *.class
javac *.java
Rem The following should pass
java DecimalPalindrome < testdata02a.txt
Rem The following should pass
java DecimalPalindrome < testdata02b.txt
Rem The following should fail as a palindrome
java DecimalPalindrome < testdata02c.txt
Rem Allowing Pause to check over
Pause