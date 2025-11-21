/* .:: header
    File Name: interestcalc.cpp
    Author: Derek Wood
    Email Address: djwood@lanminds.com
    Assignment Number: HW#3
    Due Date: 18 March 2004
    Description: Takes a total debt, a monthly payment, and an
                 interest rate  and calculates the amount of months
                 to pay off the debt and the total interest paid on
                 debt. <Updated for use of functions>
    Last Changed: 18 March 2004
*/

#include <iostream>
    using namespace std;

// Function Declarations
void welcome();
double setItem();
double setService();
double setInterest();
double output(double amt, double fee, double rate);

int main() {
	double amt, fee, rate;
	welcome();
	amt = setItem();
	fee = setService();
	rate = setInterest();
	output(amt, fee, rate);
	return 0;
}

void welcome() {
	cout << "Welcome to my program\n"
		 << "Please enter the following" << endl;
}

double setItem() {
	double input;
	cout << "\nAmount: ";
	cin >> input;
	return (input);
}

double setService() {
	double input;
	cout << "Service Fee: ";
	cin >> input;
	return (input);
}

double setInterest() {
	double input;
	cout << "Interest Rate: ";
	cin >> input;
	return (input);
}

double output(double amt, double fee, double rate) {
	double month(0);
	while (amt >= 0) {
		amt = amt + (amt * rate - fee);
		month++;
	}
    cout << "\nMonths paid: " << month
        << "\nInterest paid: $" << (fee * month + amt) << endl;
    return 0;
}
