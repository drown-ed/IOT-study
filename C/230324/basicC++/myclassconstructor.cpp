#include <iostream>
using namespace std;

class Myclass {
private:
	char ID;
	int AGE;
	char NAME[10];

public:
	Myclass(char iid, int iage, const char* iname);
	void get();
};

Myclass::Myclass(char iid, int iage, const char* iname) :ID(iid), AGE(iage)		// �����ڰ� ȣ��ǰ� ���� �ٷ� ����
{
	//ID = iid;
	//AGE = iage;
	strcpy_s(NAME, 10, iname);		// �� ���´� �����ڰ� ����ǰ� ���� ����
}

void Myclass::get() {
	cout << "ID : " << ID << endl;
	cout << "AGE : " << AGE << endl;
	cout << "NAME : " << NAME << endl << endl;
}


int main() {
	Myclass person('a', 25, "gildong");
	person.get();
}

