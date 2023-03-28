#include <iostream>

using namespace std;

class StaticTest {
private:
	static int a;
	int b;
public:
	StaticTest();
	static void setData(int aa);
	void print();
};

int StaticTest::a = 10;

StaticTest::StaticTest() {
	this->b = 20;
}

void StaticTest::setData(int aa) {
	//this->a = 30;
	a = aa;
}

void StaticTest::print() {
	cout << "a : " << a << ", " << "b : " << b << endl;
}

int main() {
	StaticTest s1, s2;
	s1.print();
	s2.print();
	return 0;
}