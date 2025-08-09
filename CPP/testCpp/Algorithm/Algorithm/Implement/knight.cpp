#include "knight.h"
using namespace std;


int knight::countMoves() {
	int col = inputData[0] - 'a' + 1; // 문자 - 아스키 코드 > 다시 숫자 변환
	int row = inputData[1] - '0'; // 아스키 코드 숫자로 변환

	// 8가지 방향 관련 각 위치 이동 가능 확인
	int result = 0;
	for (int i = 0; i < 8; i++) {

		// 이동하고자 하는 위치 확인
		int nextRow = row + dx[i];
		int nextCol = col + dy[i];

		// 해당 위치 이동 가능할 경우 카운트 증가
		if (nextRow >= 1 && nextRow <= 8 && nextCol >= 1 && nextCol <= 8) result += 1;
	}
	return result;
}

