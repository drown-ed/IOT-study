#author ��������

#include <iostream>
#include <sstream>
#include "Calculator.h"
#define _CRT_SECURE_NO_WARNINGS

using namespace std;

int main(void) {

	// 1. �Էº�

	cout << "Calculator Console Application" << endl << endl;
	cout << "Please enter the operation to perform. Format : a+b | a-b | a*b | a/b " << endl;
	cout << "Please \"ctrl + c \" to exit the program." << endl << endl;


	while (true) {

		char cper;
		char str[10];

		double num[2]{};
		string nums;

		cout << "input >> ";
		cin >> str;

		// 2. �Է� �޾� ASC2 �ڵ�� ������ üũ�� ���װ� ���� �и�

		for (int i = 0; i < strlen(str); i++) {
			if (!(static_cast<int>(str[i]) >= 48 and static_cast<int>(str[i]) <= 57)) {
				cper = str[i];
				num[0] = stod(nums);
				nums = "";
			}
			else
			{
				nums += str[i];
			}
		}
		num[1] = stod(nums);

		// 3. ���
		
		Calculator r(num[0], num[1], cper);
		r.show();

	}

	return 0;
}