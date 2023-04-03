#author 오유리나

#include <iostream>
#include "Calculator.h"
#ifndef __Calculator_h__
using namespace std;

int main() 
{

	cout << "Calculator Console Application" << endl << endl;
	cout << "Please enter the operation to perform. Format : a+b | a-b | a*b | a/b " << endl;
	cout << "Please \"ctrl + c \" to exit the program." << endl << endl;

	while (true) {
		string str = "";
		cout << "input >> ";
		cin >> str;

		Calculator s(str);
	}

}
#endif