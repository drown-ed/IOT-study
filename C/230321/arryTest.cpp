#include <iostream>

int main() {
	char ch[5] = "hong";
	ch[0] = 'h';
	ch[1] = 'o';
	ch[2] = 'n';
	ch[3] = 'g';
	ch[4] = 'e';

	for (int i = 0; i < 5; i++) {
		std::cout << ch[i];
	}

	return 0;
}