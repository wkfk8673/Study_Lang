#pragma once
#include <iostream>

using namespace std;

class GreedyMakeOne
{
private:
   int n, k;
   int result;

public:
   GreedyMakeOne(int number, int quotient) : n(number), k(quotient), result(0) {}

   void calculate();
   void printResult();
};