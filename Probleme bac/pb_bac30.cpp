#include <iostream>
using namespace std;

int armonie(int x, int y)
{
    int sdivx = 0, sdivy = 0;
    int sum = x + y;

    for (int i = 1; i <= x; ++i)
        if (x % i == 0)
            sdivx = sdivx + i;

    for (int i = 1; i <= y; ++i)
        if (y % i == 0)
            sdivy = sdivy + i;

    if (sum > sdivx && sum < sdivy)
        return 1;

    return 0;
}

int main()
{
    int x, y;
    cin >> x >> y;
    cout << armonie(x, y);

    return 0;
}