#include <iostream>
using namespace std;

int m, n;
int a[21][21];
bool gasit = false;

int main()
{
	cin >> m >> n;
	for (int i = 1; i <= m; ++i)
		for (int j = 1; j <= n; ++j)
			cin >> a[i][j];

	for (int ip = 1; ip <= m; ++ip)
		for (int iu = 1; iu <= m; ++iu)
			if (a[ip][1] == a[iu][n])
			{
				cout << a[ip][1] << ' ';
				gasit = true;
			}

	if (!gasit) cout << "nepolarizate";

	return 0;
}