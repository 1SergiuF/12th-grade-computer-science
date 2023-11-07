#include <iostream>
using namespace std;

bool VerificaDur(int x);
void numere_dure(int n);

int main()
{
    int n;
    cin >> n;
    numere_dure(n);
    return 0;
}

bool VerificaDur(int x)
{
    int p = 1;
    while (x)
    {
        if (x % 10 == 9)
            return false;
        p = p * (x % 10);
        x = x / 10;
    }

    return p >= 18;
}

void numere_dure(int n)
{
    int cnt = 0;
    int a[101];

    for (int i = 36; i <= 100; ++i)
    {
        if (VerificaDur(i))
        {
            a[++cnt] = i;
        }
    }

    if (n > cnt) cout << "Nu exista";
    else
        for (int i = 1; i <= n; ++i)
            cout << a[i] << ' ';
}