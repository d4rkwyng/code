/* .:: header
    File Name: triangle.cpp
    Author: Derek Wood
    Email Address: djwood@lanminds.com
    Assignment Number:
    Due Date: 18 March 2004
    Description: Creates an equilalateral triangle based on
                 the EndUser's input for the base.
    Last Changed: 17 March 2004
*/

#include <iostream>
    using namespace std;

int main() {
    int base, count = 0;
    cout << "Please enter a number between 1-30: ";
    cin >> base;

    if ((base >= 1) && (base <= 30)) {
        cout << "The integer was " << base
             << "\n\nI'm an equilateral triangle\n";
    } else {
        cout << "Invalid integer!\n";
        base = -1;
    }

    while (0 <= base) {
        for (int i = 0; i < (base); i++) {
            cout << " ";
        }
        for (int i = 0; i < count; i++) {
            cout << "* ";
        }
        base--;
        count++;
        cout << endl;
    }

    return 0;
}

