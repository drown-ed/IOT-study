#include <iostream>
using namespace std;

void main() {

	int a = 5, b = 11;
	const int* ptr = &a;

	a = 10;
	//*ptr = 20;		�� ���� �Ұ�
	//					int�� ���ȭ �Ǳ� ������ �����Ͱ� ����Ű�� �� ���� �Ұ�, �ּҰ� ���� ����

	cout << ptr << endl;

	ptr = &b;

	cout << a << endl;	
	cout << ptr << endl;
}