#include <iostream>

using namespace std;

int main(void) {

	int num = 10;
	int i = 0;

	cout << "True : " << true << endl;
	cout << "False : " << false << endl;

	while (1) {
		cout << i++ << endl;
		if (i > num) {
			break;
		}
	}

	cout << endl;

	cout << "sizeof 1 : " << sizeof(1) << endl;				// sizeof() ¿¬»êÀÚ
	cout << "sizeof 0 : " << sizeof(0) << endl;
	cout << "sizeof true : " << sizeof(true) << endl;
	cout << "sizeof false : " << sizeof(false) << endl;

	return 0;
}