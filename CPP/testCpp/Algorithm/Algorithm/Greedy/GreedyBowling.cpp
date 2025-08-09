#include "GreedyBowling.h"

void GreedyBowling::Input() {

	cin >> n >> m;
}

void GreedyBowling::calculate() {
	vector<int> weight(n);
	vector<int> count(m + 1, 0);

	for (int i = 0; i < n; i++) {
		cin >> weight[i];
	}
	for (int i = 0; i < weight.size(); i++) {
		int w = weight[i];
		count[w]++;
	}


	// nC2
	int total = n * (n - 1) / 2;

	// Áßº¹ °ª
	int same = 0;
	for (int i = 1; i <= m; i++) {
		same += count[i] * (count[i] - 1) / 2;
	}

	cout << total - same << endl;
}