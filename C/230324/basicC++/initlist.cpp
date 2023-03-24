/*
콜론초기화가 필요한 경우
1. 상수멤버변수
2. 객체멤버변수
3. 참조멤버변수
4. 멤버변수
*/

#include <iostream>
using namespace std;

class ConstSome {
public:
	const int val;
	ConstSome(int n) : val(n) {}
	void printval() {
		cout << val << endl;
	}
};

class RefSome {
public:
	int& ref;
	RefSome(int n) : ref(n) {}
	void printval() {
		cout << ref << endl;
	}
};

class Position {
public:
	int x, y;
	Position(int ax, int ay) {
		x = ax;
		y = ay;
	}
};

class ObjSome {
public:
	Position pos;
	ObjSome(int ax, int ay) : pos(ax, ay){}
	void printval() {
		cout << pos.x << " " << endl;
	}
};

int main() {
	ConstSome c(10);
	c.printval();

	int n = 20;
	RefSome r(n);
	r.printval();

	ObjSome o(10, 20);
	o.printval();

	return 0;
}