#author 오유리나

#pragma once
#include <iostream>
#include <vector>

using namespace std;

class Calculator {
private:
	string s;

public:
	Calculator(string str);
	double plu(vector<double> num);
	double min(vector<double> num);
	double mul(vector<double> num);
	double div(vector<double> num);
};

