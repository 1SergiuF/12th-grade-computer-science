#include <iostream>
#include <cmath>
using namespace std;

void patrate(int n, int& x, int& y)
{
    int rn = sqrt(n);
    if ((rn * rn) != n)
        x = 0, y = 0;
    else
    {
        for (int i = 2; i <= rn; ++i)
            if (rn % i == 0)
            {
                x = i;
                y = rn / x;
                break;
            }
    }

    if (x >= y)
        x = 0, y = 0;
}

int main()
{
    int n, x, y;
    cin >> n;

    patrate(n, x, y);
    cout << x << ' ' << y;

    return 0;
}