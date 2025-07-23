#pragma once

#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

class GreedyGuild
{
private:
	int n;
	vector<int> arr;
	int result = 0, cnt = 0;

public:

	void enterData();
	void calculate();
	void printResult();
};