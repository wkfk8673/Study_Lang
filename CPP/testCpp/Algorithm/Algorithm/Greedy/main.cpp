#include "GreedyChange.h"
#include "GreedyMakeOne.h"
#include "GreedyPlusORMultiple.h"
#include "GreedyGuild.h"



int main() {
   GreedyChange change(1260);
   change.calculate();
   change.printResult();

   GreedyMakeOne number(25, 5);
   number.calculate();
   number.printResult();

   GreedyPlusORMultiple number2("02984", 0);
   number2.calculate();
   number2.printResult();

   GreedyGuild number3;
   number3.enterData();
   number3.calculate();
   number3.printResult();

   int n;
   
   vector<int> arr;
   for (int i = 0; i < n; i++) {
	   int x;
	   cin >> x;
	   arr.push_back(x);
   }
   sort(arr.begin(), arr.end());



   return 0;
}