#include <iostream>

int main(void) {

	int val1, val2;
	int result = 0;

	std::cout << "변수를 차례로 입력하세요 : ";
	std::cin >> val1 >> val2;

	if (val1 < val2) {
		for (int i = val1 + 1; i < val2; i++) {
			result += i;
		}
	}
	else {
		for (int i = val2 + 1; i < val1; i++) {
			result += i;
		}
	}
	
	std::cout << "두 정수 사이의 합은 " << result;
	return 0; 

}