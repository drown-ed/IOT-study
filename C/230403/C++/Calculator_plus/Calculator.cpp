#author 오유리나

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

	// 1. find 함수를 사용해 연산자 위치를 찾고 항 분리 후 함수 호출

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

	// 연산자가 없을 경우 입력 형식 오류

	else {
		cout << "입력 형식이 잘못 됐습니다." << endl << endl;
	}
}

// 2. 연산하는 함수

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