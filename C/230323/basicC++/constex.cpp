#include <iostream>
using namespace std;

void main() {

	int a = 5, b = 11;
	const int* ptr = &a;

	a = 10;
	//*ptr = 20;		값 변경 불가
	//					int가 상수화 되기 때문에 포인터가 가리키는 값 변경 불가, 주소값 변경 가능

	cout << ptr << endl;

	ptr = &b;

	cout << a << endl;	
	cout << ptr << endl;
}