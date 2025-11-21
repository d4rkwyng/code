// Derek Wood
// CS19: C++ Programming
// Fall 2003: #1 Loan Payment Calculator
// loan.cpp

#include <iostream.h>
#include <math.h>

// function prototypes
double getAmmount();
double getInterest();
double numPayments();
double numYears();
double calc(double, double, double, double);
void display(double, double, double, double, double);

int main(void) {
  double ammount, interest, payments, years, calcpay;
  
  // Student Information
  cout << "Derek Wood\n" <<
    "djwood@lanminds.com\n" <<
    "CS19 Fall 2003: #1 Loan Payment Calculator\n";
  
  ammount = getAmmount();
  interest = getInterest();
  payments = numPayments();
  years = numYears();
  calcpay = calc(ammount, interest, payments, years); display(ammount, interest, payments, years, calcpay);
}

// Gets the EndUser's input for Ammount (Principle)
double getAmmount(){
  double ammount;
  cout << "\nWhat is the ammount to be borrowed? ";
  cin >> ammount;
  return ammount;
}

// Gets the EndUser's input for Interest
double getInterest(){
  double interest;
  cout << "What is the annual interest rate (Format: .12 = 12%)? ";
  cin >> interest;
  return interest;
}

// Gets the EndUser's input for Payments
double numPayments(){
  double payments;
  cout << "What is the number of payments each year? ";
  cin >> payments;
  return payments;
}

// Gets the EndUser's input for Years
double numYears(){
  double years;
  cout << "What is the number of years the money is to be borrowed? ";
  cin >> years;
  return years;
}

// Performs calculations
double calc(double ammount, double interest, double payments, double years){
  double powered;
  interest /= payments;
  payments *= years;
  payments *= -1;
  powered = pow(1 + interest, payments);
  return ammount / ((1 - powered) / interest);
}

// Outputs payment
void display(double ammount, double interest, double payments, double years, double calcpay){
  cout << "\nPayments: " << calcpay << endl;
}
