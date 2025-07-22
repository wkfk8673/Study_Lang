#pragma once
#include <iostream>

using namespace std;

class GreedyChange {
private:
    int n;
    int cnt;

    int coinTypes[4] = { 500, 100, 50, 10 };

public:
    GreedyChange(int money) : n(money), cnt(0) {}

    void calculate();
    void printResult();
};