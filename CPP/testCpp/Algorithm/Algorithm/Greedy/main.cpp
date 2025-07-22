#include "GreedyChange.h"
#include "GreedyMakeOne.h"

int main() {
    GreedyChange change(1260);
    change.calculate();
    change.printResult();


    GreedyMakeOne number(250,3);
    number.calculate();
    number.printResult();
    return 0;
}