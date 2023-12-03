#include <iostream>
using namespace std;

int NrZero(int a[], int n)
{
	int pos_firstp     = -1;
	int pos_firstp_dif = -1;
	int st = 1;
	int dr = n;

	while (st <= dr)
	{
		int mij = (st + dr) >> 1;

		if (a[mij] % 2 == 0)
		{
			pos_firstp = mij;
			dr = mij - 1;
		}
		else
			st = mij + 1;
	}

	if (pos_firstp == -1) return 0;
	if (a[pos_firstp] != 0) return 0;

	st = pos_firstp;
	dr = n;

	while (st <= dr)
	{
		int mij = (st + dr) >> 1;

		if (a[pos_firstp] != a[mij])
		{
			pos_firstp_dif = mij;
			dr = mij - 1;
		}
		else
			st = mij + 1;
	}

	return pos_firstp_dif - pos_firstp;
}

int main()
{
	int n;
	int a[500003];

	cin >> n;
	for (int i = 1; i <= n; ++i)
		cin >> a[i];

	cout << NrZero(a, n) << '\n';

	return 0;
}