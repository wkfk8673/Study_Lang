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

	cout << "�������� ����� �ΰ��� �۾��� �� ��� fixed ���� �̿�" << endl;
	cout << sizeof(num0) << endl;
	cout << sizeof(num1) << endl;
	cout << sizeof(num2) << endl;

	unsigned int a = 11u; // u �� �Է��Ͽ� unsigned int ���� ������־��, Ÿ�Ժ�ȯ���� ���� �߻��ϴ� ���ʿ��� ����� ���� �� ����
	long int longNum2 = 9l; // L �� �Է��Ͽ� long int ���� ������־��, Ÿ�Ժ�ȯ���� ���� �߻��ϴ� ���ʿ��� ����� ���� �� ����

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

	cout << "--------unsigned overflow Ȯ��---------" << endl;

	uint32_t num32 = numeric_limits<uint32_t>::max();
	uint32_t num32_ = num32 + 1;
	
	cout << num32 << endl;
	cout << num32_ << endl;

	cout << "--------signed overflow Ȯ��---------" << endl;

	int32_t num32_s = numeric_limits<int32_t>::max();
	int32_t num32_so = num32_s + 1;

	cout << num32_s << endl;
	cout << num32_so << endl;


	cout << "--------unsigned underflow Ȯ��---------" << endl;

	num32 = numeric_limits<uint32_t>::min();
	num32_ = num32 - 1;

	cout << num32 << endl;
	cout << num32_ << endl;

	cout << "--------signed underflow Ȯ��---------" << endl;

	num32_s = numeric_limits<int32_t>::min();
	num32_so = num32_s - 1;

	cout << num32_s << endl;
	cout << num32_so << endl;
	*/

	cout << "--------�ε� �Ҽ���---------" << endl;

	float num0 = 1.5;
	float num1 = num0 * 1.5;
	float num2 = num0 / 2;
	float num3 = num0 - 3;

	cout << "num0 : " << num0 << endl;
	cout << "num1 : " << num1 << endl;
	cout << "num2 : " << num2 << endl;
	cout << "num3 : " << num3 << endl;

}