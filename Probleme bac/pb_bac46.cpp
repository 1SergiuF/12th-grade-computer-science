#include <iostream>
using namespace std;

int a[21][21];
int n, k;
int ord;

int main()
{
	cin >> n >> k;
	for (int i = 1; i <= k * n; ++i)
	{
		ord = i;
		for (int j = 1; j <= k * n; ++j)
		{
			a[i][j] = ord;
			if (j >= k && j % k == 0)
				ord++;
		}
	}

	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n * k; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}

	return 0;
}