#include <stdio.h>

int main() {

	const int num = 10;
	int* p = &num;

	printf("p�� : %p\n", p);
	printf("p�� ����Ʈ �� : %d\n", *p);

	*p = 20;
	printf("���� �� p�� ����Ʈ �� : %d\n", *p);
	printf("�����ͷ� ���� �� num �� : %d\n", num);

	return 0;

}