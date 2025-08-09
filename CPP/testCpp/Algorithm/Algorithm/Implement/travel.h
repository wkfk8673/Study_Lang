#pragma once

#include <iostream>
#include <string>

using namespace std;





class travel
{
private:
	int n; // ÀÌµ¿ È½¼ö
	string plans;
	int x = 1, y = 1;

	int dx[4] = { 0,0,-1,1 };
	int dy[4] = { -1,1,0,0 };

	char moveTypes[4] = { 'L','R','U','D' };



public:

	void Input();
	void calculate();
};