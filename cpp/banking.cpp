// Derek Wood
// CS19: C++ Programming
// Fall 2003 #4 Banking with Class
// banking.cpp

#include <iostream>
#include <cctype> // tolower function
using namespace std;

class CheckingAcct {
public:
  CheckingAcct();
  void deposit(double amt);
  int checkWithdraw(double amt);
  int atmWithdraw(double amt);
  void setBalance(double amt);
  double getBalance();
private:
  double balance;
};

// Default Constructor (sets all starting balances to $100)
CheckingAcct::CheckingAcct() {
  balance = 100.0;
}

// Deposits
void CheckingAcct::deposit(double amtdeposit) {
  balance += amtdeposit;
}

// Withdraws using Checking
int CheckingAcct::checkWithdraw(double amtWithdraw) {
  if (amtWithdraw <= balance) {
    balance -= amtWithdraw;
    return 1;
  } else {
    balance -= 10; // Subtracts $10 for bounced check
    return 0;
  }
}

// Withdraws using ATM
int CheckingAcct::atmWithdraw(double amtATM) {
  if (amtATM <= balance) {
    balance -= amtATM+1;
    return 1;
  } else
    return 0;
}

// Returns balance
double CheckingAcct::getBalance() {
  return balance;
}

// Sets balance to sent value
void CheckingAcct::setBalance(double amtBalance) {
  balance = amtBalance;
}


// User-friendly client
int main() {
  // Intialize Variables
  const int aS=10;
  char transtype;
  double array[aS]; // Set up array of doubles to hold the balances
  int accountptr;
  double transamt;
  bool process=true;
  CheckingAcct ck; // Declare constructor
  
  // About info
  cout << "Derek Wood\n"
       << "djwood@lanminds.com\n"
       << "CS19 Fall 2003: #4 Banking with Class\n" << endl;
  
  for (int i = 0; i < aS; i++)
    array[i] = ck.getBalance(); // Initialize the array (0..9)
  while (process) {
    cout << "Please enter the account number (0-9 or -1 to Exit): ";
    cin >> accountptr;
    if ((accountptr >= 0) && (accountptr <= 9))
      transtype='s';
    else if (accountptr == -1)
      return 0; // Exits program
    else {
      cout << "Account Number Invalid\n" << endl;
      transtype='x';
    }
    while (transtype != 'x') {
      ck.setBalance(array[accountptr]);
      cout << "Please enter transaction type (? for help): ";
      cin >> transtype;
      //cout << endl;
      transtype = tolower(transtype);
      switch (transtype) {
      case 'd': // Deposits into the selected account
	cout << "Amount to be deposited: ";
	cin >> transamt;
	if (transamt > 0) {
	  ck.deposit(transamt);
	  array[accountptr] = ck.getBalance();
	  cout << "$" << transamt << " has been deposited.\n"
	       << "Balance is now: $" << array[accountptr] << endl << endl;;
	} else {
	  cout << "Invalid deposit amount" << endl;
	}
	break;
      case 'c': // Withdraws from the selected account
	cout << "Amount to be withdraw-ed (Checking): ";
	cin >> transamt;
	if (transamt < 0)
	  transamt *= -1;
	if (ck.checkWithdraw(transamt) == 1) {
	  array[accountptr] = ck.getBalance();
	  cout << "$" << transamt << " has been withdraw-ed.\n"
	       << "Balance is now: $" << array[accountptr] << endl << endl;
	} else {
	  array[accountptr] = ck.getBalance();
	  cout << "Insufficient funds ($10.00 Service Fee)\n"
	       << "Balance is now: $" << array[accountptr] << endl << endl;
	}
	break;
      case 'a': // Withdraws from the selected account and subracts $1
	cout << "Amount to be withdraw-ed (ATM) "
	     << "(Service Fee: $1.00): ";
	cin >> transamt;
	if (transamt < 0)
	  transamt *= -1;
	if (ck.atmWithdraw(transamt) == 1) {
	  array[accountptr] = ck.getBalance();
	  cout << "$" << transamt << " has been withdraw-ed.\n"
	       << "Balance is now: $" << array[accountptr] << endl << endl;
	} else {
	  cout << "Cannot withdraw negative amount" << endl;
	}
	break;
      case 'b': // Retrieves balance of selected account
	array[accountptr] = ck.getBalance();
	cout << "Balance is now: $" << array[accountptr] << endl << endl;
	break;
      case 'x': // Breaks Loop
	break;
      case '?': // Prints out list of available commands
	cout << "List of Commands:\nD = Deposit to Account\n"
	     << "C = Checking withdrawal from Account\n"
	     << "A = ATM withdrawal from Account\n"
	     << "B = Balance Inquiry of Account\n"
	     << "X = Exit to selection of Account(s)\n" << endl;
	break;
      }
    }
  }
  return 0; // Exits program
}
