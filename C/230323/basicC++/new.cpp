#include <iostream>

using namespace std;

void main() {

	int* arr;

	arr = (int*)malloc(sizeof(int));		// heap 영역에 할당 후 시작 주소값 return 돼 저장됨
	cout << arr << endl;

	free(arr);
}