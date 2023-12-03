#include <iostream>
using namespace std;

void secventa(int& n)
{
	int m = n;
    int p = 1;
    while (m)
    {
        if (m % 10 == 2)
            if ((m / 10) % 10 == 2)
                n -= 2 * p;

        p *= 10;
        m /= 10;
    }
}

int main()
{
    int n;
    cin >> n;

    secventa(n);

    cout << n;

    return 0;
}