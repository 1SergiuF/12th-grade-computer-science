#include <iostream>
using namespace std;

const int N = 103;
int a[N][N];
int n;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(0); cout.tie(0);

    cin >> n;
    for (int i = 1; i <= n; ++i)
        for (int j = 1; j <= n; ++j)
        {
            cin >> a[i][j];

            if (j == 1)
                cout << a[i][j] << ' ';

            if (i == n && j > 1)
                cout << a[i][j] << ' ';
        }

    for (int i = n - 1; i >= 1; --i)
        cout << a[i][n] << ' ';

    for (int j = n - 1; j >= 2; --j)
        cout << a[1][j] << ' ';

    return 0;
}