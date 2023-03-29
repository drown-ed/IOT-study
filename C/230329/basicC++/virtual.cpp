#include <iostream>

using namespace std;

class First
{
public:
	virtual void MyFunc() { cout << "1 Func " << endl; }
};

class Second : public First
{
public:
	virtual void MyFunc() { cout << "2 Func " << endl; }
};

class Third : public Second
{
public:
	virtual void MyFunc() { cout << "3 Func " << endl; }
};

int main(void) {
	Third* tptr = new Third();
	Second* sptr = tptr;
	First* fptr = sptr;

	fptr->MyFunc();
	sptr->MyFunc();
	tptr->MyFunc();
	delete tptr;
	return 0; 
}