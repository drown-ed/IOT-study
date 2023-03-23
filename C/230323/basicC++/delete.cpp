#include <iostream>
using namespace std;


int main() {

	int size;
	int* arr;
	
	cout << "배열 개수" << endl;
	cin >> size;

	arr = new int[size];


	for (int i = 0; i < size; i++) {
		cout << i + 1 << endl;
		cin >> *(arr + i);
	}

	for (int i = 0; i < size; i++) {
		cout << arr[i] << endl;
		cout << *(arr + i) << endl;
	}
}