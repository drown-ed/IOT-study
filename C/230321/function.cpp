#include <iostream>

//int main() {
//
//	int a = 10;
//	int b = 20;
//	int res;
//
//	res = 10 + 20;
//
//	std::cout << res;
//
//	return 0;
//}


//void func() {
//	
//	int a, b;
//	int res = a + b;
//
//	std::cin >> a >> b;
//	std::cout << res;
//
//}
//
//int main() {
//
//	func();
//
//	return 0;
//}


//void sum(int a, int b) {
//
//	int res = a + b;
//	std::cout << res;
//
//}
//
//int main() {
//	
//	int a, b;
//
//	std::cin >> a >> b;
//	sum(a, b);
//
//	return 0;
//}


int sum(int a, int b) {
	return a + b;
}

int main() {
	int a, b;
	std::cin >> a >> b;
	std::cout << sum(a, b);
}
