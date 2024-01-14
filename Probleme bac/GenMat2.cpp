#include <iostream>
using namespace std;

const int Dim = 25;
int n;
int a[Dim][Dim];

int main()
{
    cin >> n;

    for (int j = 1; j <= n; ++j)
    {
        for (int i = 1; i <= n; ++i)
            if (i != j)
                a[i][j] = n - j + 1;
    }

    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= n; ++j)
            cout << a[i][j] << ' ';
        cout << '\n';
    }

    return 0;
}