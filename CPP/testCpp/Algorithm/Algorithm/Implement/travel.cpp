#include "travel.h"


void travel::Input() {
	cin >> n;
	// 버퍼 비우기
	cin.ignore();
	// 이동 계획 입력
	getline(cin, plans);
}

void travel::calculate() {
	for (int i = 0; i < plans.size(); i++) {
		char plan = plans[i];
		int nx = -1, ny = -1;
		for (int j = 0; j < 4; j++) {
			if (plan == moveTypes[j]) {
				nx = x + dx[j];
				ny = y + dy[j];
			}
		}
		if (nx < 1 || ny < 1 || nx > n || ny > n) continue;
		x = nx;
		y = ny;
	}

	cout << x << ' ' << y << '\n';
}
