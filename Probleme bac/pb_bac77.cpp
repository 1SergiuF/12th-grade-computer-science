#include <iostream>
#include <algorithm>
using namespace std;

int n, k;
int a[21][21];

int main()
{
	cin >> n >> k;
	for (int i = 1; i <= n; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];

	for (int j = 1; j <= k - 2; ++j)
		swap(a[k][j], a[k][j + 1]);

	cout << '\n';
	for (int i = 1; i <= n; ++i)
	{
		for (int j = 1; j <= n; ++j)
			cout << a[i][j] << ' ';
		cout << '\n';
	}

	return 0;
}