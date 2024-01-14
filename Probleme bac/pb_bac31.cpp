#include <iostream>
using namespace std;

int m, n;
int a[21][21];
bool ok;

int main()
{
    cin >> m >> n;
    for (int i = 1; i <= m; ++i)
        for (int j = 1; j <= n; ++j)
            cin >> a[i][j];

    for (int j = 1; j < n; ++j)
        for (int i = 2; i <= m; ++i)
            if (a[1][j] == a[i][n])
            {
                ok = true;
                cout << a[1][j] << ' ';
            }

    if (!ok)
        cout << "nu exista";

    return 0;
}