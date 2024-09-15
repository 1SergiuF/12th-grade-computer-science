#include <iostream>
#include <fstream>
using namespace std;

ifstream fin("bac.in");

int main()
{
    int x;
    int min1 = 1e9 + 1;
    int min2 = min1;
    int min3 = min2;

    while (fin >> x)
    {
        if (x % 100 == 20)
        {
            if (min1 > x)
                min1 = x;

            if (min2 > x && x > min1)
            {
                min3 = min2;
                min2 = x;
            }
        }
    }

    cout << min1 << ' ' << min2 << ' ' << min3;

    return 0;
}