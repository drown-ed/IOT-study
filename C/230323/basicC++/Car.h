#ifndef __CAR_H__
#define __CAR_H__		// 다른 헤더 파일에 있을 수 있어서 중복 방지하는 코드

namespace CAR_CONST
{
	enum {
		ID_LEN = 20, MAX_SPD = 200, FUEL_STEP = 2,
		ACC_STEP = 10, BRK_STEP = 10
	};
}

class Car {
	private:
		char gameID[CAR_CONST::ID_LEN];
		int fuelGauge;
		int curSpeed;
	public:
		void InitMembers(char* ID, int fuel);
		void ShowCarState();
		void Accel();
		void Break();
};

#endif