#include <iostream>
#include <cmath>
using namespace std;

int n, m;
int main()
{
    cin >> n >> m;

    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= m; ++j)
            cout << min(i, j) << ' ';
        cout << '\n';
    }

    return 0;
}