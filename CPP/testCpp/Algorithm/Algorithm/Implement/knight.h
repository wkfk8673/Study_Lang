#pragma once

#include <string>


class knight {
public:

	std::string inputData;
	int countMoves();

private:
	const int dx[8] = { 2,2,-2,-2,1,1,-1,-1 };
	const int dy[8] = { 1,-1,1,-1,2,-2,2,-2 };
};