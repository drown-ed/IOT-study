#include <iostream>

int swap(int *a, int *b) {
	int c;

	c = *a;
	*a = *b;
	*b = c;

	return *a, *b;
}


int main() {

	int num1 = 20, num2 = 30;
	swap(&num1, &num2);

	std::cout << num1 << ' ' << num2;

	return 0;
}