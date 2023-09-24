#include <iostream>
using namespace std;

int ns, np;
int a[51][1001];
int rez[1001];

int main()
{
    cin >> ns >> np;

    for (int i = 1; i <= ns; ++i)
        for (int j = 1; j <= np; ++j)
            cin >> a[i][j];

    for (int i = 1; i <= ns; ++i)
    {
        int v_max = -1, poz = 0;
        for (int j = 1; j <= np; ++j)
        {
            if (v_max < a[i][j])
            {
                v_max = a[i][j];
                poz = j;
            }
        }

        rez[i] = poz;
    }

    for (int j = 1; j <= ns; ++j)
        cout << j << ':' << rez[j] << ' ';

    return 0;
}