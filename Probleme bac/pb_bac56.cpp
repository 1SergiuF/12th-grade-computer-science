#include <iostream>
using namespace std;

int m, n;
int a[21][21];

int main()
{
	cin >> m >> n;
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];

	int complv = 0;
	bool ok = false;

	for (int j = 2; j <= n; ++j)
	{
		ok = false;
		for (int i = 1; i <= m; ++i)
			if (a[i][j] == a[i][1])
			{
				ok = true;
				break;
			}

		if (!ok) ++complv;
	}

	cout << complv;

	return 0;
}