#include <iostream>
using namespace std;

long long Oglindit(long long n);
int main()
{
    long long n;
    cin >> n;

    if (Oglindit(n) == n)
        cout << n << ' ' << n;
    else
    {
        int prefix = 0, sufix = 0;
        int prefix_max = 0, sufix_max = 0;
        long long oglindit = Oglindit(n);

        while (oglindit && n)
        {
            prefix = prefix * 10 + oglindit % 10;
            sufix = sufix * 10 + n % 10;

            if (Oglindit(prefix) == prefix)
                prefix_max = prefix;

            if (Oglindit(sufix) == sufix)
                sufix_max = sufix;

            oglindit /= 10;
            n /= 10;
        }

        cout << prefix_max << ' ' << sufix_max;
    }

    return 0;
}

long long Oglindit(long long n)
{
    long long ogl = 0;
    while (n)
    {
        ogl = ogl * 10 + n % 10;
        n /= 10;
    }

    return ogl;
}