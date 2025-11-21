// Derek Wood
// CS19: C++ Programming
// Fall 2003 #2 Moo! (Similar to Mastermind)
// moo.cpp

#include <iostream>
#include <ctime>
using namespace std;

const int SECRET_SIZE = 10; // size of secret number array
const int GUESS_SIZE = 4; // size of guess number array
// const int TRUE = 1;
// const int FALSe = 0;

// Each time initialize_secret() is called, it picks a new secret number.
// Initializes the secret number array to the digits 0..9 and then
// rearranges the secret sequence into an alternative order by randomly
// interchanging numbers. The first four of these digits are the
// secret number. The rest are not used.
void initialize_secret(int secret[]) { 
  int i, random_index, number;

  // fill array with values 0..9 
  for(i = 0; i < SECRET_SIZE; i++) 
    secret[i] = i;
 
  // Creates a random array
  for(i = 0; i < SECRET_SIZE; i++){ 
    // Pick a random element 
    random_index = rand() % SECRET_SIZE; 
    // Swap the two elements 
    number = secret[i]; 
    secret[i] = secret[random_index]; 
    secret[random_index] = number;
    //cout << number;
  } 
}

// Reads in a guess and stores it into the array guess.
// A guess consists of four integers each in the range 0..9.
// (i.e. 4 5 6 7) A valid guess only has a digit appearing once.
// You do not need to check for non-valid input.
void read_guess(int guess[]) {
  int i;
  cout << "Your Guess? (or -1 0 0 0 to exit) ";
  for (i = 0; i < GUESS_SIZE; i++){
    cin >> guess[i];
  }
}

// Returns 1 (a true value) if the guess is not identical to the
// secret number. Otherwise returns 0 (a false value). Also should
// print out how many "cows" and how many "bulls" there are. In addition,
// you need to support the following "cheat code": if the guess is all 0's
// (0 0 0 0), print out the secret number. Also, treat (0 0 0 0) as a
// normal guess.
int no_match(int secret[], int guess[]) {
  int i, j, cows = 0, bulls = 0, sum = 0;
  
  for (i = 0; i < GUESS_SIZE; i++) {
    sum += guess[i];
    if (secret[i] == guess[i])
      bulls++;
    else {
      for (j = 0; j < GUESS_SIZE; j++)
	if (secret[i] == guess[j])
	  cows++;
    }
  }

  if (sum == 0) {
    cout << "Secret number revealed: ";
    for (i = 0; i < GUESS_SIZE; i++) {
      cout << secret[i];
      cout << " ";
    }
    cout << "\n";
  // implemented a possible exit during the middle of gameplay
  } else if (sum == -1) {
    cout << "Thank you for playing!!\n";
    exit(1);
  }

  cout << "bulls = " << bulls << " cows = " << cows << "\n";

  if (bulls == 4)
    return false;
  return true;
}

// Seeds random number generator. Initialize secret numbers.
// Then enter into a while loop, looping until the person wins
// the game by getting 4 bulls. Should print out how many guesses
// it took.
int main(void){ 
  int secret[SECRET_SIZE]; 
  int guess[GUESS_SIZE]; 
  int numguesses = 0;
  // more variables defined here
  int i;

  // initialization here
  initialize_secret(secret);

  // print instructions here
  cout << "\nDerek Wood\n";
  cout << "djwood@lanminds.com\n";
  cout << "CS19 Fall 2003: #2 Moo! array exercise\n";
  cout << "\nWelcome to the game of moo.\n" <<
    "I will pick a secret four digit number, you guess it\n" <<
    "When inputting your guess, separate the digits by a space (ie: 4 5 6 7)\n" <<
    "I'll tell you how many cows and bulls you get.\n" <<
    "When you get four bulls, you win!\n";

  // get first guess
  read_guess(guess);

  // loop: continue guessing until match made
  numguesses++;
  while (no_match(secret, guess)) {
    read_guess(guess);
    numguesses++;
  }

  // number is guessed 
  // print the secret number, how many guesses it took
  cout << "You did it!! The secret number was: ";
  for (i = 0; i < GUESS_SIZE; i++){
    cout << secret[i];
    cout << " ";
  }
  cout << "\nYou took " << numguesses << " guesses.\n";
  
  return 0;
}
