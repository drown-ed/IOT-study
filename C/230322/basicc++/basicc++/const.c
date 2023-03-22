#include <stdio.h>

int main() {

	const int num = 10;
	int* p = &num;

	printf("p값 : %p\n", p);
	printf("p의 포인트 값 : %d\n", *p);

	*p = 20;
	printf("변경 후 p의 포인트 값 : %d\n", *p);
	printf("포인터로 변경 후 num 값 : %d\n", num);

	return 0;

}