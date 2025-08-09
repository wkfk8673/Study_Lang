#include "travel.h"
#include "knight.h"

std::string str;
int summary = 0;

int main() {
	knight k;
	cin >> k.inputData;
	cout << k.countMoves() << '\n';

	for (int i = 0; i < str.size() / 2; i++) {
		summary += str[i] - '0';
	}

	for (int i = str.size() / 2; i < str.size(); i++) {
		summary -= str[i] - '0';
	}

	if (summary == 0) cout << "LUCKY" << '\n';
	else cout << "READY" << '\n';
}