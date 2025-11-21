/* .:: header
    File Name: interestcalc.cpp
    Author: Derek Wood
    Email Address: djwood@lanminds.com
    Assignment Number: HW#3
    Due Date: 18 March 2004
    Description: Takes a total debt, a monthly payment, and an
                 interest rate  and calculates the amount of months
                 to pay off the debt and the total interest paid on
                 debt.
    Last Changed: 3 March 2004
*/

#include <iostream>
    using namespace std;

int main() {
    double counter, interest = 0.015, service = 50, initial = 1000;
    double intPaid = 0;
    cout << "Interest Calculator\n"
        << "Price = $" << initial
        << "\nInterest = " << (interest * 100)
        << "\nService Charge = $" << service << endl;
	while (initial >= 0) {
		initial = initial + (initial * interest - service);
		counter++;
	}
	intPaid = counter * service + initial;
    cout << "\nTotal months paid: " << counter
        << "\nTotal interest paid: $" << intPaid << endl;
        //<< "\nRefund: $" << (initial * -1) << endl;
    return 0;
}

