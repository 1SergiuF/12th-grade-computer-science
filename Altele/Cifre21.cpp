#include <iostream>
using namespace std;

bool ContineZero(int n);

int main()
{
    int n, x;
    cin >> n;

    int cnt = 0;
    while (n)
    {
        cin >> x;
        if (ContineZero(x) || !x)
            ++cnt;
        
        --n;
    }

    cout << cnt;

    return 0;
}

bool ContineZero(int n)
{
    while (n)
    {
        if (n % 10 == 0)
            return true;
        n /= 10;
    }

    return false;
}