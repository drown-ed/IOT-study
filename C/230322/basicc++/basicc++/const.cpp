#include <iostream>

int main() {

	int num1 = 100;
	int num2 = 200;

	const int* pa = &num1;				// data 값 상수화

	std::cout << pa << std::endl;

	pa = &num2;

	std::cout << pa << std::endl;

	int* const pb = &num1;				// 포인터 변수의 상수화

	std::cout << pb << std::endl;


}