#include <iostream>
#include <array>

using namespace std;


int main() 
{
	int n = 0;
	int k = 0;

	int target = 0;
	int result = 0;

	cin >> n;

	cin.ignore(numeric_limits<streamsize>::max(), '\n');

	cin >> k;


	while (true)
	{
		target = (n / k) * k;
		result += (n - target);
		n = target;

		if (n < k) break;

		result++;
		n /= k;
	}

	result += (n - 1);
	cout << result << endl;
}