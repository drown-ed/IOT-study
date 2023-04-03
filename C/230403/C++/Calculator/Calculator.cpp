#author ��������

#ifndef __Calculator_h__
#include <iostream>
#include "Calculator.h"

using namespace std;

// 1. �ʱ�ȭ�ϴ� ������
Calculator::Calculator(double ix, double iy, char icper)
	: x(ix), y(iy)
{
	cper = icper;
}

// 2. switch case���� �̿��� �Լ� ȣ��
void Calculator::show() {

	switch (cper){
	case '+':
		cout << Calculator::plu() << endl << endl;
		break;
	case '*':
		cout << Calculator::mul() << endl << endl;
		break;
	case '-':
		cout << Calculator::min() << endl << endl;
		break;
	case '/':
		if (Calculator::div() == 0) {
			cout << "Attempted to divide by zero!" << endl << endl;
		}
		else {
			cout << Calculator::div() << endl << endl;
		}
		break;
	}

}


// 3. �����ϴ� �Լ�
double Calculator::plu() {
	return x + y;
}

double Calculator::min() {
	return x - y;
}

double Calculator::mul() {
	return x * y;
}

double Calculator::div() {
	if (y == 0) {
		return 0;
	}
	return x / y;
}

#endif