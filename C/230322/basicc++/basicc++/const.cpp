#include <iostream>

int main() {

	int num1 = 100;
	int num2 = 200;

	const int* pa = &num1;				// data �� ���ȭ

	std::cout << pa << std::endl;

	pa = &num2;

	std::cout << pa << std::endl;

	int* const pb = &num1;				// ������ ������ ���ȭ

	std::cout << pb << std::endl;


}