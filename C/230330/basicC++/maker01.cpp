#include <iostream>

using namespace std;

class Person {

private:
	char name[30];
	int birthday;

public:
	Person(const char* iname, int birth)
		: birthday(birth)
	{
		strcpy_s(name, iname);
	}

	void showPerson()
	{
		cout << "name : " << name << endl;
		cout << "birthday : " << birthday << endl << endl;
	}

};

/*

Person::Person(const char* iname, int birth)
	: birthday(birth)
{
	strcpy_s(name, iname);
}

void Person::showPerson()
{
	cout << "name : " << name << endl;
	cout << "birthday : " << birthday << endl << endl;
}


*/

void main() {

	Person p1("ȫ�浿", 19990909);
	p1.showPerson();

	Person p2(p1);
	p2.showPerson();

	Person p3 = p2;
	p3.showPerson();

}