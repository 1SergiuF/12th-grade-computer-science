#include <iostream>
using namespace std;

long long nrmaxim(long long n);
int main()
{
    int n;
    cin >> n;
    cout << nrmaxim(n);
    return 0;
}

long long  nrmaxim(long long n)
{
    long long x = 1,p = 0, maxi = -1;
    long long aux = n;
    while(aux)
    {
        x *= 10;
        ++p;
        aux /= 10;
    }
    while(p)
    {
        n = n % (x / 10) * 10 + n / (x / 10);
        if( n> maxi) maxi = n;
        --p;
    }
    return maxi;
}