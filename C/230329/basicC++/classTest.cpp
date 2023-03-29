#include <iostream>

using namespace std;

class Person 
{
private:
	char name[30];
	int age;
public:
	Person(const char*, int);
	void getData();
};

class Student : public Person
{
private:
	int studentId;

public:
	Student(const char*, int, int);
	void showData();
};

Person::Person(const char* name, int age)
{
	strcpy_s(this->name, 30, name);
	this->age = age;
}

void Person::getData()
{
	cout << "이름 : " << this->name << endl;
	cout << "나이 : " << this->age << endl;
}

Student::Student(const char* name, int age, int id) : Person(name, age) {
	this->studentId = id;
}

void Student::showData()
{
	cout << "ID : " << this->studentId << endl;
}

int main()
{
	Student s("오유리나", 20, 55);
	s.getData();
	s.showData();

	return 0;
}