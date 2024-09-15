#include <iostream>
using namespace std;

bool Prim(int x)
{
    if (x < 2) return false;
    if (x == 2) return true;
    if (x % 2 == 0) return false;

    for (int i = 3; i * i <= x; i += 2)
        if (x % i == 0)
            return false;
    return true;
}

int factori(int n, int m)
{
    int dn = 2, dm = 2;
    int pn, pm;
    int nr = 0;

    while (n > 1 && m > 1)
    {
        pn = 0;
        pm = 0;
        while (n % dn == 0)
        {
            pn++;
            n /= dn;
        }

        while (m % dm == 0)
        {
            pm++;
            m /= dm;
        }

        if (pn != 0 && pm != 0)
            nr++;

        dn++;
        dm++;
    }

    return nr;
}

int main()
{
    int n, m;
    cin >> n >> m;

    cout << factori(n, m);

    return 0;
}