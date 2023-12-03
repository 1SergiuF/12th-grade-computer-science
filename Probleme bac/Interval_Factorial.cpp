#include <iostream>
using namespace std;

int factorial(int n)
{
    int p = 1;
    for (int i = 1; i <= n; ++i)
        p *= i;

    return p;
}
void interval(int n, int& a, int& b)
{
    a = factorial(n - 1) + 1;
    b = factorial(n + 1) - 1;
}

int main()
{
    int n, a, b;
    cin >> n;
    interval(n, a, b);

    cout << a << ' ' << b;

    return 0;
}