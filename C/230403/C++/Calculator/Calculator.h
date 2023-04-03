#author 오유리나

#pragma once
#include <iostream>

using namespace std;

class Calculator {
private:
	double x, y;
	char cper;

public:
	Calculator(double x, double y, char cper);
	void show();

	double plu();
	double min();
	double mul();
	double div();
};