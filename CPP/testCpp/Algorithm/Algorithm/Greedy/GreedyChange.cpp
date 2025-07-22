#include "GreedyChange.h"   // 선언부 헤더파일 include

using namespace std;

void GreedyChange::calculate() {
    for (int i = 0; i < 4; i++) {
        cnt += n / coinTypes[i];
        n %= coinTypes[i];
    }
}

void GreedyChange::printResult() {
    cout << cnt << '\n';
}