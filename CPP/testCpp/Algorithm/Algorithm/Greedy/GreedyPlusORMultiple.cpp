#include "GreedyPlusORMultiple.h"

void GreedyPlusORMultiple::calculate()
{
	result = str[0] - '0';

	for (int i = 1; i < str.size(); i++) {
		int num = str[i] - '0';
		if (num <= 1 || result <= 1) result += num;
		else result *= num;
	}
}

void GreedyPlusORMultiple::printResult()
{
	cout << result << '\n';
}
