#include <iostream>

using namespace std;

class Person {

private:
	char * name;
	int birthday;

public:
	Person(const char* iname, int birth)
		: birthday(birth)
	{
		int len = strlen(iname) + 1;
		name = new char[len];
		strcpy_s(this->name, len, iname);
	}

	Person(const Person& other) {
		birthday = other.birthday;

		int len = strlen(other.name) + 1;
		name = new char[len];
		strcpy_s(name, len, other.name);
	}

	Person& operator=(const Person& other) {
		delete[] name;

		int len = strlen(other.name) + 1;
		name = new char[len];
		strcpy_s(name, len, other.name);

		birthday = other.birthday;

		return *this;
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

int main() {

	Person p1("홍길동", 19990909);
	p1.showPerson();

	Person p2 = p1;
	p2.showPerson();

	Person p3("강감찬", 20001201);		// 연산자 오버로딩
	p3 = p1;

	p3.showPerson();

	return 0;
}