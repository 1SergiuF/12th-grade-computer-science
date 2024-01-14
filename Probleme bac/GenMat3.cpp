#include <iostream>
using namespace std;

const int N = 21;
int n, m;
int a[N][N];

int main()
{
    cin >> n >> m;

    int k = 1;
    for (int i = 1; i <= n; ++i)
        for (int j = 1; j <= m; ++j)
        {
            a[i][j] = k * k;
            k += 2;
        }

    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= m; ++j)
            cout << a[i][j] << ' ';
        cout << '\n';
    }

    return 0;
}