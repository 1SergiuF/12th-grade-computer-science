#include <iostream>
using namespace std;

int S(int n);
int abundent(int n);
int main()
{
    cout << abundent(7);
    return 0;
}

int S(int n)
{
    int s = 0;
    for (int i = 1; i <= n; ++i)
        if (n % i == 0)
            s += i;

    return s;
}

int abundent(int n)
{
    for (int i = 1; i < n; ++i)
        if ((double)S(n) / n <= (double)S(i) / i)
            return 0;

    return 1;
}