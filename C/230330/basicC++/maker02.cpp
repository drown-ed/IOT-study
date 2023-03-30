#include <iostream>

using namespace std;

class Person {

private:
	char name[30];
	int birthday;

public:
	Person(const char* name, int birth)
		: birthday(birth)
	{
		strcpy_s(this->name, name);
	}

	void showPerson()
	{
		cout << "name : " << name << endl;
		cout << "birthday : " << birthday << endl << endl;
	}

	~Person() {
		delete[] name;
		cout << "delete" << endl;
	}
};

void main() {

	Person *p1 = new Person("ȫ�浿", 19990909);
	p1 -> showPerson();

	Person * p2 = p1;
	p2 -> showPerson();

	Person * p3 = p2;
	p3 -> showPerson();

	p1->~Person();
	p2->~Person();
	p3->~Person();

}