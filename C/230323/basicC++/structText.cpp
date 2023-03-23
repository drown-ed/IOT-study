#include <iostream>
using namespace std;

struct human {
	char name[20];
	int age;
}Human;

int main() {

	struct human h = { "ȫ�浿", 23 };
	
	cout << h.name << ' ' << h.age;

	return 0;
}