#include "GreedyString.h"

void GreedyString::enterData()
{
	cin >> str;
}

void GreedyString::calculate()
{
	if (str[0] == '0') {
		count0 += 1;
	}
	else
	{
		count1 += 1;
	}

	for (int i = 0; i < str.size(); i++) {
		if (str[i] != str[i + 1]) {
			if (str[i + 1] == '0') count0 += 1;
			else count1 += 1;
		}
	}
}

void GreedyString::printResult()
{
	cout << min(count0, count1) << '\n';
}
