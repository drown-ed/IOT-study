#include <iostream>

void func() {
	std::cout << "func()" << std::endl; 
}

void func(int a) {
	std::cout << "func(a)" << std::endl;
}

int main() {

	int n = 10;
	func();
	func(n);

	return 0;
}