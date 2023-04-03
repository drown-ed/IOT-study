#author ��������

#pragma once
#include <iostream>
#include <sstream>
#include <vector>

#include "Calculator.h"
#ifndef __Calculator_h__
using namespace std;


Calculator::Calculator(string str)
	: s(str)
{
	int a = 0;
	vector<double> num;

	// 1. find �Լ��� ����� ������ ��ġ�� ã�� �� �и� �� �Լ� ȣ��

	if (s.find("+") != string::npos) {
		a = s.find("+");
		num.push_back(stod(s.substr(0, a)));
		num.push_back(stod(s.substr(a + 1)));
		cout << Calculator::plu(num) << endl << endl;
	}
	else if (s.find("-") != string::npos) {
		a = s.find("-");
		num.push_back(stod(s.substr(0, a)));
		num.push_back(stod(s.substr(a + 1)));
		cout << Calculator::min(num) << endl << endl;
	}
	else if (s.find("/") != string::npos) {
		a = s.find("/");
		num.push_back(stod(s.substr(0, a)));
		num.push_back(stod(s.substr(a + 1)));
		if (Calculator::div(num) == 0) {
			cout << "Attempted to divide by zero!" << endl << endl;
		}
		else {
			cout << Calculator::div(num) << endl << endl;
		}
	}
	else if (s.find("*") != string::npos) {
		a = s.find("*");
		num.push_back(stod(s.substr(0, a)));
		num.push_back(stod(s.substr(a + 1)));
		cout << Calculator::mul(num) << endl << endl;
	}

	// �����ڰ� ���� ��� �Է� ���� ����

	else {
		cout << "�Է� ������ �߸� �ƽ��ϴ�." << endl << endl;
	}
}

// 2. �����ϴ� �Լ�

double Calculator::plu(vector<double> num) {
	return num.at(0) + num.at(1);
};
double Calculator::min(vector<double> num) {
	return num.at(0) - num.at(1);
};
double Calculator::mul(vector<double> num) {
	return num.at(0) * num.at(1);
};
double Calculator::div(vector<double> num) {
	if (num.at(1) == 0) {
		return 0;
	}
	return num.at(0) / num.at(1);
}

#endif