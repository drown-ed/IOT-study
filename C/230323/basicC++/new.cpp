#include <iostream>

using namespace std;

void main() {

	int* arr;

	arr = (int*)malloc(sizeof(int));		// heap ������ �Ҵ� �� ���� �ּҰ� return �� �����
	cout << arr << endl;

	free(arr);
}