#include <iostream>
using namespace std;

class Myclass {
private:
	char ID;
	int AGE;
	char NAME[10];

public:
	void set(char iid, int iage, const char *iname);
	void get();
};

void Myclass::set(char iid, int iage, const char* iname) {
	strcpy_s(NAME, 10, iname);
	ID = iid;
	AGE = iage;
}

void Myclass::get() {
	cout << "ID : " << ID << endl;
	cout << "AGE : " << AGE << endl;
	cout << "NAME : " << NAME << endl << endl;
}


int main() {
	Myclass person;

	person.set('a', 23, "ȫ�浿");
	person.get();
}

