#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;

    int a[7][7];

    for (int pas = 1; pas <= 6; ++pas)
    {
        a[pas][pas] = 0;
        for (int i = pas + 1; i <= 6; ++i)
            a[i][pas] = n % 10;

        for (int j = pas + 1; j <= 6; ++j)
            a[pas][j] = n % 10;

        if (n == 0) break;
        n /= 10;
    }

    for (int i = 1; i <= 6; ++i)
    {
        for (int j = 1; j <= 6; ++j)
            cout << a[i][j] << ' ';
        cout << '\n';
    }

    return 0;
}