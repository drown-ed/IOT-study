#include <iostream>
#include <string>

using namespace std;

int main(void) {
	string st1 = "I like";
	string st2 = "string class";
	string st3 = st1 + st2;

	cout << st1 << endl;
	cout << st2 << endl;
	cout << st3 << endl;

	st1 += st2;
	if (st1 == st3)
		cout << "���� ���ڿ�" << endl;
	else
		cout << "���� x ���ڿ�" << endl;

	string st4;
	cout << "���ڿ� �Է� : ";
	cin >> st4;
	cout << "�Է� ���ڿ� : " << st4 << endl;
	return 0;
}