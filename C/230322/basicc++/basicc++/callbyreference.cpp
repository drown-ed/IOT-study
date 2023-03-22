#include <iostream>

void swap(int *n1, int *n2) {
	int tmp;

	tmp = *n1;
	*n1 = *n2;
	*n2 = tmp;

	std::cout << *n1 << ' ' << *n2 << std::endl;
}

int main() {
	int n1 = 20, n2 = 30;

	swap(&n1, &n2);

	std::cout << n1 << ' ' << n2 << std::endl;
}