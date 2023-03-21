#include <iostream>

int func(int a = 10, int b = 20) {
	return a + b;
}

int main() {

	std::cout << func() << std::endl;
	std::cout << func(14) << std::endl;
	std::cout << func(13, 16) << std::endl;

	return 0;
}

