#include <iostream>
using namespace std;

class Ctest {
private:
	int num;
public:
	Ctest(int n) : num(n) {
		cout << num << "Ctest Constructor" << endl;
	}
	~Ctest() {
		cout << "Ctest Destructor" << endl;
	}
	void func() {
		cout << "C test func ()" << endl;
	}
};

class CtestSub : public Ctest {
	int snum;
public:
	CtestSub(int n1, int n2) : Ctest(n1), snum(n2) {
		cout << snum << "C testsub constructor" << endl;
	}
	~CtestSub() {
		cout << snum << "C testsub Destructor" << endl;
	}
};

int main()
{
	Ctest c1(10);
	cout << "========================" << endl;
	CtestSub c2(1, 10);
	cout << "========================" << endl;
	Ctest* ps = new CtestSub(3, 33);					// 메모리 동적할당을 해서 소멸자 호출이 안 됨.
	return 0;
}