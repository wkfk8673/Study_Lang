#include "GreedyGuild.h"

void GreedyGuild::enterData()
{
	cin >> n;
	for (int i = 0; i < n; i++) {
		int x;
		cin >> x;
		arr.push_back(x);
	}
	sort(arr.begin(), arr.end()); //오름차순 정렬
}

void GreedyGuild::calculate()
{
	for (int i = 0; i < n; i++) {
		cnt += 1;
		if (cnt >= arr[i]) {
			result += 1;
			cnt = 0;
		}
	}
}

void GreedyGuild::printResult()
{
	cout << result << '\n';
}
