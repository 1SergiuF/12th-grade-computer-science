#include <iostream>
using namespace std;

bool VPrim(int x)
{
	if (x < 2) return false;
	if (x == 2) return true;
	if (x % 2 == 0) return false;

	for (int i = 3; i * i <= x; i += 2)
		if (x % i == 0)
			return false;

	return true;
}

void putere(int n, int& d, int& p)
{
	int d2 = 2; d = 2;
	int p2 = 0; p = 0;

	while (n > 1)
	{
		p2 = 0;
		while (n % d2 == 0)
		{
			n /= d2;
			p2++;
		}

		if (p2)
		{
			if (p2 > p && VPrim(d2))
			{
				p = p2;
				d = d2;
			}
			else if (p2 == p && VPrim(d2) && d2 > d)
				d = d2;
		}

		d2++;
	}
}

int main()
{
	int n, d, p;
	cin >> n;

	putere(n, d, p);

	cout << d << ' ' << p;

	return 0;
}