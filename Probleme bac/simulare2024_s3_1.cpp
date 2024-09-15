#include <iostream>
#include <cmath>
using namespace std;

int Impare(int n)
{
	int p = 0;
	int cnt = 0;
	int m = n;

	while (m)
	{
		if ((m % 10) % 2 == 1)
		{
			p = pow(10, cnt + 1) * (m % 10) +
				pow(10, cnt) * (m % 10) + p;
			cnt++;
		}

		else
			p = pow(10, cnt) * (m % 10) + p;

		cnt++;
		m /= 10;
	}

	if (p == n) return -1;
	else return p;
}

int main()
{
	int n;
	cin >> n;

	cout << Impare(n);

	return 0;
}