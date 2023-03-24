#include <iostream>
using namespace std;

class Myclass {
private:
	char ID;
	int AGE;
	char* NAME;

public:
	Myclass(char iid, int iage, const char* iname);
	void get();
	~Myclass()
	{
		delete[]NAME;
		cout << "called destructor" << endl;
	}
};

Myclass::Myclass(char iid, int iage, const char* iname) :ID(iid), AGE(iage)		// 생성자가 호출되고 나면 바로 실행
{
	int len = strlen(iname) + 1;
	NAME = new char[len];
	strcpy_s(NAME, len, iname);
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

