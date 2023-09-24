#include <iostream>
using namespace std;

void divX(int n, int x);
int main()
{   
    int n, x;
    cin >> n >> x;
    divX(n, x);

    return 0;
}

void divX(int n, int x)
{
    while (n)
    {
        cout << x * n << ' ';
        --n;
    }
}