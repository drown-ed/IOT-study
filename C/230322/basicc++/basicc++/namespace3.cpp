#include <iostream>

namespace realperson {
	void person(void);
	void people(void);
}

//namespace realperson {
//	void people(void);
//}

namespace subperson {
	void person(void);
}

int main(void) {
	realperson::person();
	return 0;
}

void realperson::person() {
	std::cout << "realperson person" << std::endl;
	people();
	subperson::person();
}

void realperson::people() {
	std::cout << "realperson people" << std::endl;
}

void subperson::person() {
	std::cout << "subperson person" << std::endl;
}