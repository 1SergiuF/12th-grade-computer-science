#include <iostream>
using namespace std;

bool VerifPrim(int x)
{
	if (x < 2) return false;
	if (x == 2) return true;
	if (x % 2 == 0) return false;

	for (int i = 3; i * i <= x; i += 2)
		if (x % i == 0)
			return false;

	return true;
}

int putere(int n, int p)
{
	if (!VerifPrim(p)) return -1;

	int pu = 0;
	int d = 2;

	while (n > 1)
	{
		pu = 0;
		while (n % d == 0)
		{
			n /= d;
			++pu;
		}

		if (d == p)
			return pu;
		d++;
	}

	return -1;
}

int main()
{
	int n, p;
	cin >> n >> p;

	cout << putere(n, p);

	return 0;
}