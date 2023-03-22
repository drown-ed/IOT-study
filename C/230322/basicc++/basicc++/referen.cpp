#include <iostream>
using namespace std;

void main() {

	int num1 = 1020;
	cout << num1 << endl;
	
	int& num2 = num1;
	cout << num2 << endl;

	num1 = 30;
	cout << num1 << endl;
	cout << num2 << endl;

	num2 = 40; 
	cout << num1 << endl;
	cout << num2 << endl;
}