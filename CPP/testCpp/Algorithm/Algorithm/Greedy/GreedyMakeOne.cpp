#include "GreedyMakeOne.h"

void GreedyMakeOne::calculate()
{
	while (true)
	{
		int target = (n / k) * k;
		result += (n - target);
		n = target;

		if (n < k) break;
		result++;
		n /= k;
	}

	result += (n - 1);
}

void GreedyMakeOne::printResult()
{
	cout << result << '\n';
}
