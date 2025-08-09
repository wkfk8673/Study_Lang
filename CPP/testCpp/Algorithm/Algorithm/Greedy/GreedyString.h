#pragma once
#include <iostream>

using namespace std;

class GreedyString
{
private:
	string str;
	
	int count0 = 0, count1 = 0;

public:

	void enterData();
	void calculate();
	void printResult();
};