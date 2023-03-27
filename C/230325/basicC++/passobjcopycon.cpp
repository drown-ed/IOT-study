#include <iostream>
using namespace std;

class SoSimple {
private: int num;
public :
	SoSimple(int n) : num(n)
	{}
	SoSimple(const SoSimple& copy) : num(copy.num) {
		cout << "called so simple(const so simple& copy" << endl;
	}
	void Showdata() {
		cout << "num : " << num << endl;
	}
};

void SimpleFuncObj(SoSimple ob) {
	ob.Showdata();
}

int main(void) {
	SoSimple obj(7);
	cout << "함수호출전" << endl;
	SimpleFuncObj(obj);
	cout << "함수호출후" << endl;
	return 0;
}