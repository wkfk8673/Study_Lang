#include <iostream>
#include <numeric>
using namespace std;

int main()
{
	/*
	int intNum = 0;
	long longNum = 0;
	int* intPoint = &intNum;

	cout << sizeof(intNum) << endl;
	cout << sizeof(longNum) << endl;
	cout << sizeof(intPoint) << endl << endl;


	//fixed width int

	int8_t num0 = 0;
	int16_t num1 = 0;
	int32_t num2 = 0;

	cout << "정수형의 사이즈가 민감한 작업을 할 경우 fixed 값을 이용" << endl;
	cout << sizeof(num0) << endl;
	cout << sizeof(num1) << endl;
	cout << sizeof(num2) << endl;

	unsigned int a = 11u; // u 을 입력하여 unsigned int 임을 명시해주어야, 타입변환으로 인해 발생하는 불필요한 계산을 줄일 수 있음
	long int longNum2 = 9l; // L 을 입력하여 long int 임을 명시해주어야, 타입변환으로 인해 발생하는 불필요한 계산을 줄일 수 있음

	cout << a << endl;
	cout << longNum2 << endl;

	cout << "-----------------" << endl;

	cout << (int)numeric_limits<uint8_t>::max() << endl;
	cout << numeric_limits<uint16_t>::max() << endl;
	cout << numeric_limits<uint32_t>::max() << endl;
	cout << numeric_limits<uint64_t>::max() << endl;

	cout << "-----------------" << endl;

	cout << (int)numeric_limits<int8_t>::max() << endl;
	cout << numeric_limits<int16_t>::max() << endl;
	cout << numeric_limits<int32_t>::max() << endl;
	cout << numeric_limits<int64_t>::max() << endl;

	cout << "-----------------" << endl;

	cout << (int)numeric_limits<int8_t>::min() << endl;
	cout << numeric_limits<int16_t>::min() << endl;
	cout << numeric_limits<int32_t>::min() << endl;
	cout << numeric_limits<int64_t>::min() << endl;

	cout << "--------unsigned overflow 확인---------" << endl;

	uint32_t num32 = numeric_limits<uint32_t>::max();
	uint32_t num32_ = num32 + 1;
	
	cout << num32 << endl;
	cout << num32_ << endl;

	cout << "--------signed overflow 확인---------" << endl;

	int32_t num32_s = numeric_limits<int32_t>::max();
	int32_t num32_so = num32_s + 1;

	cout << num32_s << endl;
	cout << num32_so << endl;


	cout << "--------unsigned underflow 확인---------" << endl;

	num32 = numeric_limits<uint32_t>::min();
	num32_ = num32 - 1;

	cout << num32 << endl;
	cout << num32_ << endl;

	cout << "--------signed underflow 확인---------" << endl;

	num32_s = numeric_limits<int32_t>::min();
	num32_so = num32_s - 1;

	cout << num32_s << endl;
	cout << num32_so << endl;
	*/

	cout << "--------부동 소수점---------" << endl;

	float num0 = 1.5;
	float num1 = num0 * 1.5;
	float num2 = num0 / 2;
	float num3 = num0 - 3;

	cout << "num0 : " << num0 << endl;
	cout << "num1 : " << num1 << endl;
	cout << "num2 : " << num2 << endl;
	cout << "num3 : " << num3 << endl;

}