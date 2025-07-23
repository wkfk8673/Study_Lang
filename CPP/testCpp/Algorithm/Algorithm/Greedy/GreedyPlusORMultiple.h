#pragma once
#include <iostream>

using namespace std;

class GreedyPlusORMultiple
{
private:
	string str;
	long long result;

public:
	GreedyPlusORMultiple(string str, long long result) : str(str), result(0) {}

	void calculate();
	void printResult();
};