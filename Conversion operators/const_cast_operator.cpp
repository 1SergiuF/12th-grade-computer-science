#include <iostream>
using namespace std;

void Change(const int& b);
int main()
{
    int a = 100;
    Change(a);
    Change(3000);
    cout << a;
}

void Change(const int& b)
{
    cout << "schimb " << b << '\n';

    int& c = const_cast<int&>(b);

    c = 200;  // DA !
}