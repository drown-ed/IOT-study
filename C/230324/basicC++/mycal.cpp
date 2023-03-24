#include <iostream>

using namespace std;

class Mycal {
	int num1, num2;
public:
	Mycal(int a, int b);
	void add();
	void sub();
	void mul();
	void div();
};

Mycal::Mycal(int a, int b)
	: num1(a), num2(b)
{
}

void Mycal::add()
{
	cout << num1 << " + " << num2 << " = " << num1 + num2 << endl;
}

void Mycal::sub()
{
	cout << num1 << " - " << num2 << " = " << num1 - num2 << endl;
}

void Mycal::mul()
{

	cout << num1 << " * " << num2 << " = " << num1 * num2 << endl;
}

void Mycal::div()
{
	//if (num1 == 0 || num2 == 0) {
	//	cout << "0���� ���� �� �����ϴ�." << endl;;
	//}
	//else

	try {
		if (num2 == 0)
			throw num2;
		cout << num1 << " / " << num2 << " = " << num1 / num2 << endl;
	}
	catch (int expn) {
		cout << "0���� ���� �� �����ϴ�." << endl;
	}
	
}

int main() {

	bool run = true;

	while (run) {
		int a, b, c;

		cout << "�� ���� �Է��ϼ���. >> ";
		cin >> a >> b;

		Mycal s(a, b);
		s.add();
		s.sub();
		s.mul();
		s.div();
	}

	

	return 0;
}