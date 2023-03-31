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
		cout << "동일 문자열" << endl;
	else
		cout << "동일 x 문자열" << endl;

	string st4;
	cout << "문자열 입력 : ";
	cin >> st4;
	cout << "입력 문자열 : " << st4 << endl;
	return 0;
}