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

Myclass::Myclass(char iid, int iage, const char* iname) :ID(iid), AGE(iage)		// 생성자가 호출되고 나면 바로 실행
{
	//ID = iid;
	//AGE = iage;
	strcpy_s(NAME, 10, iname);		// 이 형태는 생성자가 실행되고 나서 실행
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

